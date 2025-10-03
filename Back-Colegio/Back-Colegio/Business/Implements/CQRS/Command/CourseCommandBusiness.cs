using AutoMapper;
using Business.Implements.Bases;
using Data.Interfaces.Group.Commands;
using Entity.Dtos.School.Course;
using Entity.Model.School;
using Microsoft.Extensions.Logging;
using Utilities.Helpers.Validations;

namespace Business.Implements.CQRS.Command
{
    public class CourseCommandBusiness : BaseCommandsBusiness<Course, CourseDto>
    {
       
        public CourseCommandBusiness(
            ICommands<Course> data,
            IMapper mapper,
            ILogger<CourseCommandBusiness> _logger,
            IGenericHerlpers helpers
            ) : base(data, mapper, _logger, helpers)
        {

        }



        // metodo de validación
        //protected async Task EnsureValid(D dto)
        //{
        //    var validationResult = await _helpers.Validate(dto);
        //    if (!validationResult.IsValid)
        //    {
        //        var errors = string.Join(", ", validationResult.Errors);
        //        throw new ArgumentException($"Validación fallida: {errors}");
        //    }
        //}

        /// <summary>
        ///  Metodod de reparticion de estudiantes de un grupo
        ///  indicando el grado al cual va a distribuir
        /// </summary>
        //public virtual async Task<bool> DistributionServices(int GradoId)
        //{
        //    try
        //    {
        //        var entity = _mapper.Map<Dto>(dto);
        //        return await _data.UpdateAsync(entity);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Error al actualizar {typeof(T).Name} desde DTO: {ex.Message}");
        //        throw;
        //    }
        //}









    }
}
