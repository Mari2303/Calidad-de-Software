using AutoMapper;
using Entity.Dtos.School.Grade;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class GradeMap : Profile
    {
        public GradeMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Grade, GradeDto>().ReverseMap();


         
        }
    }
}
