using Entity.Model.Global;

namespace Entity.Model.School
{
    public class Grade : ABaseEntity
    {

        public int PeriodId { get; set; }
        public int SubjectId { get; set; }   
        public int StudentId { get; set; }   
        public decimal Score { get; set; }
        public string? Comments { get; set; }
   

        // Navegación
        public Period? Period { get; set; }
        public Subject? Subject { get; set; }
        public Student? Student { get; set; }

    }
}
