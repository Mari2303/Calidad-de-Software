using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Hall : ABaseEntity
    {
        public string? Name { get; set; }
        public int Capacity { get; set; }

        public IEnumerable<Course> courses { get; set; }

    }
}
