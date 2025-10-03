using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Hall;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class HallController : GenericController
       <
           Hall,
           HallDto,
           HallDto
       >
    {
        public HallController(
            IQueryServices<Hall, HallDto> q,
            ICommandService<Hall, HallDto> c)
          : base(q, c) { }
    }
}
