using AutoMapper;
using Entity.Dtos.School.Student;
using Entity.Dtos.School.Subject;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class SubjectMap : Profile
    {
        public SubjectMap()
        {
            
                // Mapeo de Rol a RolDto y viceversa
                CreateMap<Subject, SubjectDto>().ReverseMap();


         
        }
    }
}
