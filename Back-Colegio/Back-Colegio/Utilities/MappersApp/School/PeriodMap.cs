using AutoMapper;
using Entity.Dtos.School.Period;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class PeriodMap : Profile
    {
        public PeriodMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Period, PeriodDto>().ReverseMap();


         
        }
    }
}
