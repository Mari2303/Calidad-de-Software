using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Subject;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class SubjectController : GenericController
       <
           Subject,
           SubjectDto,
           SubjectDto
       >
    {
        public SubjectController(
            IQueryServices<Subject, SubjectDto> q,
            ICommandService<Subject, SubjectDto> c)
          : base(q, c) { }
    }
}
