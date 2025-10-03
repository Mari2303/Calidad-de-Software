using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Tution;
using Entity.Model.School;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class TuitionController : GenericController
       <
           Tuition,
           TutionDto,
           TutionDto
       >
    {

        public readonly IQueryTutionServices _queryTutionServices;
        public TuitionController(
            IQueryTutionServices q,
            ICommandService<Tuition, TutionDto> c)
          : base(q, c) 
        {
            _queryTutionServices = q;
        }

        [HttpGet("Students/Degree/{id}")]
        public virtual async Task<IActionResult> GetStudentCourse(int id)
        {
            var query = await _queryTutionServices.GetStudentDegree(id);
            return Ok(query);
        }


    }
}
