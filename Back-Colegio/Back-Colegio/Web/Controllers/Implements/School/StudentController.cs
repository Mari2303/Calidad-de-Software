using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Student;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class StudentController : GenericController
       <
           Student,
           StudentDto,
           StudentDto
       >
    {
        public StudentController(
            IQueryServices<Student, StudentDto> q,
            ICommandService<Student, StudentDto> c)
          : base(q, c) { }
    }
}
