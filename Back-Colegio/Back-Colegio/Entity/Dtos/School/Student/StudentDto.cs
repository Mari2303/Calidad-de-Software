using Entity.Dtos.Global;

namespace Entity.Dtos.School.Student
{
    public class StudentDto : ABaseDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Gender { get; set; }              
        public string? DocumentNumber { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool State { get; set; }
        public int? CourseId { get; set; }
    }
}
