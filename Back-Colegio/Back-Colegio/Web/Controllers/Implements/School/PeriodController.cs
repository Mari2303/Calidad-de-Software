using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Period;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class PeriodController : GenericController
       <
           Period,
           PeriodDto,
           PeriodDto
       >
    {
        public PeriodController(
            IQueryServices<Period, PeriodDto> q,
            ICommandService<Period, PeriodDto> c)
          : base(q, c) { }
    }
}
