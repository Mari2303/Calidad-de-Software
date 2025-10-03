using Entity.Dtos.Global;

namespace Entity.Dtos.School.Grade
{
    public class GradeDto : ABaseDto
    {
        public int PeriodId { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public decimal Score { get; set; }
        public string? Comments { get; set; }

    }
}
