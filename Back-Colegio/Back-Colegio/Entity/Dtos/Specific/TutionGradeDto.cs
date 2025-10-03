using Entity.Dtos.Global;
using Entity.Model.School;

namespace Entity.Dtos.School.Specific
{
    public class TutionGradeDto : ABaseDto
    {
        public int SchoolId { get; set; }
        public int DegreeId { get; set; }
        public int StudentId { get; set; }


    }
}
