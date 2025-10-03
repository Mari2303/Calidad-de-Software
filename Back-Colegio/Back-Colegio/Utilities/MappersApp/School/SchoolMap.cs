using AutoMapper;
using Entity.Dtos.School.Grade;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class SchoolMap : Profile
    {
        public SchoolMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Schools, SchoolDto>().ReverseMap();


         
        }
    }
}
