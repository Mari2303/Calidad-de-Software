using AutoMapper;
using Entity.Dtos.School.Course;
using Entity.Model.School;

namespace Utilities.MappersApp.School
{
    public class CourseMap : Profile
    {
        public CourseMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CoursesStudentsDto>().ReverseMap();

        }
    }
}
