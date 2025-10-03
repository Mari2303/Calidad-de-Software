using Entity.Model.Global;
using Google.Protobuf.Reflection;

namespace Entity.Model.School
{
    public class Schools : ABaseEntity
    {
        public string? NameSchool { get; set; }
        public string? CodeDane { get; set; }
        public string? EmailInstitution { get; set; }
        public string? Address { get; set; }

        // Navegación
        public ICollection<Period> Periods { get; set; } = new List<Period>();
        public ICollection<Tuition> Tuitions { get; set; } = new List<Tuition>();

    }
}
