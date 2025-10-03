using Entity.Dtos.Global;

namespace Entity.Dtos.School.Period
{
    public class PeriodDto : ABaseDto
    {
        public int SchoolId { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
