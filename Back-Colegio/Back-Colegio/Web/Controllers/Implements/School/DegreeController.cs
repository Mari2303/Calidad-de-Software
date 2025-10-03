using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Degree;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class DegreeController : GenericController
       <
           Degree,
           DegreeDto,
           DegreeDto
       >
    {
        public DegreeController(
            IQueryServices<Degree, DegreeDto> q,
            ICommandService<Degree, DegreeDto> c)
          : base(q, c) { }
    }
}
