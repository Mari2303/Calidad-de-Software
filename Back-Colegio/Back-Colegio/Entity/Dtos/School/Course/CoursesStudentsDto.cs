using Entity.Dtos.Global;
using Entity.Dtos.School.Student;

namespace Entity.Dtos.School.Course
{
    public class CoursesStudentsDto : ABaseDto
    {
        public int DegreeId { get; set; }
        public string? Name { get; set; }
        public IEnumerable<StudentDto> Students { get; set; } 


    }
}
