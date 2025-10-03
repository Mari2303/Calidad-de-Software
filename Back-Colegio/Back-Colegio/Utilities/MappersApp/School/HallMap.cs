using AutoMapper;
using Entity.Dtos.School.Hall;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class HallMap : Profile
    {
        public HallMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Hall, HallDto>().ReverseMap();


         
        }
    }
}
