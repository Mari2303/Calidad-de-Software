using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Grade;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class GradeController : GenericController
       <
           Grade,
           GradeDto,
           GradeDto
       >
    {
        public GradeController(
            IQueryServices<Grade, GradeDto> q,
            ICommandService<Grade, GradeDto> c)
          : base(q, c) { }
    }
}
