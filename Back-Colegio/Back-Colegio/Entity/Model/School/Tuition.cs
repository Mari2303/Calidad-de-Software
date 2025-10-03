using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Tuition : ABaseEntity
    {
        public int SchoolId { get; set; }
        public int DegreeId { get; set; }
        public int StudentId { get; set; }

        // Navegación
        public Schools? School { get; set; }
        public Degree? Degree { get; set; }
        public Student? Student { get; set; }

    }
}
