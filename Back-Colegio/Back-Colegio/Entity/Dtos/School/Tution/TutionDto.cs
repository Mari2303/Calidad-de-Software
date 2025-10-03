using Entity.Dtos.Global;

namespace Entity.Dtos.School.Tution
{
    public class TutionDto : ABaseDto
    {
        public int SchoolId { get; set; }
        public int DegreeId { get; set; }
        public int StudentId { get; set; }

    }
}
