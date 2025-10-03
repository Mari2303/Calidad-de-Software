using AutoMapper;
using Entity.Dtos.School.Degree;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class DegreeMap : Profile
    {
        public DegreeMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Degree, DegreeDto>().ReverseMap();


         
        }
    }
}
