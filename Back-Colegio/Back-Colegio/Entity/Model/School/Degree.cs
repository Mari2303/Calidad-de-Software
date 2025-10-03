using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Degree : ABaseEntity
    {
        public string? Name { get; set; }
        public bool State { get; set; }
   

        // Navegación
        public ICollection<Tuition> Tuitions { get; set; } = new List<Tuition>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
