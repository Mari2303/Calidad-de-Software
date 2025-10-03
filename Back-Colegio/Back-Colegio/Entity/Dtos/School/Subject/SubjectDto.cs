using Entity.Dtos.Global;

namespace Entity.Dtos.School.Subject
{
    public class SubjectDto : ABaseDto
    {
        public int DegreeId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }

    }
}
