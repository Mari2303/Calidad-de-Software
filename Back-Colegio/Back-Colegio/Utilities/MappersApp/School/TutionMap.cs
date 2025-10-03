using AutoMapper;
using Entity.Dtos.School.Tution;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class TutionMap : Profile
    {
        public TutionMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Tuition, TutionDto>().ReverseMap();


         
        }
    }
}
