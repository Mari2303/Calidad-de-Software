using AutoMapper;
using Entity.Dtos.School.Student;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class StudentMap : Profile
    {
        public StudentMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Student, StudentDto>().ReverseMap();


         
        }
    }
}
