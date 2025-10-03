using AutoMapper;
using Business.Implements.Bases;
using Business.Interfaces.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Dtos.School.Course;
using Entity.Model.School;
using Microsoft.Extensions.Logging;
using Utilities.Helpers.Validations;

namespace Business.Implements.Querys.Security
{
    public class CourseQueryBusiness : BaseQueryBusiness<Course, CourseDto>, IQueryCourseServices
    {
        protected readonly IQuerysCourse _data;

        public CourseQueryBusiness(
            IQuerysCourse data,
            IMapper mapper,
            ILogger<CourseQueryBusiness> _logger,
            IGenericHerlpers helpers) : base(data, mapper, _logger, helpers)
        {
            _data = data;
        }

        public async Task<CoursesStudentsDto> GetStudentCourse(int CourseId)
        {
            try
            {
                var entities = await _data.QueryCourseWithStudentsAsync(CourseId);

                _logger.LogInformation($"Obteniendo los municipios");

                var result = _mapper.Map<CoursesStudentsDto>(entities);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener al obtener el curso con id {CourseId}");
                throw;
            }
        }
    }
}
