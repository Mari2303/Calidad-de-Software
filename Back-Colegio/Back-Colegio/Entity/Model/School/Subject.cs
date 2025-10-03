using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Subject : ABaseEntity
    {
        public int DegreeId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }

        // Navegación
        public Degree? Degree { get; set; }
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }
}
