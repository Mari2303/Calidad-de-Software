using Entity.Dtos.Global;

namespace Entity.Dtos.School.Grade
{
    public class SchoolDto : ABaseDto
    {
        public string? NameSchool { get; set; }
        public string? CodeDane { get; set; }
        public string? EmailInstitution { get; set; }
        public string? Address { get; set; }

    }
}
