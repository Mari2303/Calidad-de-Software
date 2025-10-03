using AutoMapper;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
using Entity.Model.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mysqlx.Expr;
using Utilities.Helpers.Validations;

namespace Business.Implements.CQRS.Command
{
    public class RepartoCommandBusiness 
    {
        // Data consulta cursos
        public IQuerysCourse _queryCourse;

        // Data de matricula
        public IQuerysTution _queryTution;

        // Ejecutor de data de estudiante
        public ICommandStuden _commandsStudent;

        private readonly ILogger<RepartoCommandBusiness> _logger;

        public RepartoCommandBusiness(
            IQuerysCourse queryCourse,
            IQuerysTution queryTution,
            ICommandStuden commandsStudent,
            ILogger<RepartoCommandBusiness> logger)
        {
            _queryCourse = queryCourse;
            _queryTution = queryTution;
            _commandsStudent = commandsStudent;
            _logger = logger;
        }


        /// <summary>
        /// Distribuye los estudiantes del grado en los cursos del mismo grado,
        /// de forma equilibrada (diferencia máx 1 por curso).
        /// </summary>
        public async Task<bool> DistributionStudent(int gradeId)
        {
            // 1) Cursos del grado
            var courses = (await _queryCourse.QueryCourseDegree(gradeId))
                ?.OrderBy(c => c.Id)
                .ToList();

            if (courses == null || courses.Count == 0)
            {
                _logger.LogWarning("No hay cursos para el grado {GradeId}.", gradeId);
                return false;
            }

            // 2) Estudiantes del grado (matriculados)
            var students = (await _queryTution.QueryByStudenGrade(gradeId))
                ?.OrderBy(s => s.Id)   // determinismo
                .ToList();

            if (students == null || students.Count == 0)
            {
                _logger.LogInformation("No hay estudiantes para distribuir en el grado {GradeId}.", gradeId);
                return true; // nada que hacer, pero no es error
            }

            // 3) Reparto round-robin: 0,1,2,...,m-1, 0,1,2,... (equilibrado)
            int m = courses.Count;
            int idx = 0;


            // 4) Actualización. Para no saturar el DB, hacemos lotes.
            const int BATCH = 100;
            var tasks = new List<Task<bool>>(BATCH);

            foreach (var s in students)
            {
                int courseId = courses[idx % m].Id;
                idx++;

                tasks.Add(_commandsStudent.UpdateStudentCourseAsync(s.Id, courseId));

                if (tasks.Count == BATCH)
                {
                    var results = await Task.WhenAll(tasks);
                    if (results.Any(r => r == false))
                        throw new DbUpdateException("Fallo en la actualización de CourseId en un lote.");

                    tasks.Clear();
                }
            }

            if (tasks.Count > 0)
            {
                var results = await Task.WhenAll(tasks);
                if (results.Any(r => r == false))
                    throw new DbUpdateException("Fallo en la actualización de CourseId en el último lote.");
            }

            _logger.LogInformation(
                "Distribución completada: {Students} estudiantes en {Courses} cursos para grado {GradeId}.",
                students.Count, courses.Count, gradeId);

            return true;
        }
    }
}
