using Entity.Model.Global;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Model.School
{
    public class Period : ABaseEntity
    {
        public int SchoolId { get; set; }
        public string? Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        // Navegación
        public Schools? School { get; set; }
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }
}
