using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Course : ABaseEntity
    {
        public int DegreeId { get; set; }
        public string? Name { get; set; }
        public int? HallId { get; set; }

        // Navegación 
        public Degree? Degree { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public Hall Halls { get; set; }
    }
}
