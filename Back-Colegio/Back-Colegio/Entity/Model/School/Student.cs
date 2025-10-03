using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Student : ABaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Gender { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool State { get; set; }
        public int? CourseId { get; set; }

        // Navegación
        public ICollection<Tuition> Tuitions { get; set; } = new List<Tuition>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public Course Course { get; set; }


    }
}
