using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Course;
using Entity.Model.School;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class CourseController : GenericController
       < Course,
           CourseDto,
           CourseDto
       >
    {

        public readonly IQueryCourseServices _QueryCourseServices;

        public CourseController(
            IQueryCourseServices q,
            ICommandService<Course, CourseDto> c)
          : base(q, c) 
        { 
            _QueryCourseServices = q;
        }

        [HttpGet("Students/Course/{id}")]
        public virtual async Task<IActionResult> GetStudentCourse(int id)
        {
           var query = await _QueryCourseServices.GetStudentCourse(id); 
           return Ok(query);
        }


    }
}
