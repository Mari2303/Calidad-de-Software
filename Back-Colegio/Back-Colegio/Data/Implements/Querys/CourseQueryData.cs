using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Querys.Security
{
    public class CourseQueryData : BaseGenericQuerysData<Course>, IQuerysCourse
    {
        protected readonly ILogger<CourseQueryData> _logger;
        protected readonly AplicationDbContext _context;

        public CourseQueryData(AplicationDbContext context, ILogger<CourseQueryData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        // Metodo que sirve como consulta de que estudiantes tiene 
        public virtual async Task<Course?> QueryCourseWithStudentsAsync(int courseId)
        {
            try
            {
                var course = await _context.Courses
                    .AsNoTracking()
                    .Where(c => c.Id == courseId)
                    .Include(c => c.Students)
                    .FirstOrDefaultAsync();

                _logger.LogInformation("Consulta de {Entity} realizada", typeof(Course).Name);
                return course; // puede ser null si no existe
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error consultando {Entity}", typeof(Course).Name);
                throw;
            }
        }

        public virtual async Task<IEnumerable<Course>?> QueryCourseDegree(int courseId)
        {
            try
            {
                var course = await _context.Courses
                    .AsNoTracking()
                    .Where(c => c.DegreeId == courseId)
                    .ToListAsync();

                _logger.LogInformation("Consulta de {Entity} realizada", typeof(Course).Name);
                return course; // puede ser null si no existe
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error consultando {Entity}", typeof(Course).Name);
                throw;
            }
        }

    }
}
