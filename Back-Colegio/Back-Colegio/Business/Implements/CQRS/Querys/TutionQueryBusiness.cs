using AutoMapper;
using Business.Implements.Bases;
using Business.Interfaces.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Dtos.School.Student;
using Entity.Dtos.School.Tution;
using Entity.Model.School;
using Microsoft.Extensions.Logging;
using Utilities.Helpers.Validations;

namespace Business.Implements.Querys.Security
{
    public class TutionQueryBusiness : BaseQueryBusiness<Tuition, TutionDto>, IQueryTutionServices
    {
        protected readonly IQuerysTution _data;

        public TutionQueryBusiness(
            IQuerysTution data,
            IMapper mapper,
            ILogger<TutionQueryBusiness> _logger,
            IGenericHerlpers helpers) : base(data, mapper, _logger, helpers)
        {
            _data = data;
        }

        public virtual async Task<IEnumerable<StudentDto>> GetStudentDegree(int idDegree)
        {
            try
            {
                // 1) Traes las matrículas (ya vienen con Student cargado)
                var tuitions = await _data.QueryByStudenGrade(idDegree); // IEnumerable<Tuition>

                // 2) Proyectas solo estudiantes, evitas nulls y duplicados
                var students = tuitions
                    .Select(t => t.Student)
                    .Where(s => s != null)!                 // seguridad por si acaso
                    .GroupBy(s => s!.Id)                    // únicos por Id
                    .Select(g => g.First()!)                // tomas uno por Id
                    .OrderBy(s => s.Id)                     // o LastName/FirstName si prefieres
                    .ToList();

                // 3) Mapeas al DTO que ya existe
                var result = _mapper.Map<List<StudentDto>>(students);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener al obtener los municipios del departamento con el id {idDegree}");
                throw;
            }
        }




    }
}
