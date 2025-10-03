using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Grade;
using Entity.Model.School;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{
    public class SchoolController : GenericController
       <
           Schools,
           SchoolDto,
           SchoolDto
       >
    {
        public SchoolController(
            IQueryServices<Schools, SchoolDto> q,
            ICommandService<Schools, SchoolDto> c)
          : base(q, c) { }
    }
}
