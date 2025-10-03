using Entity.Dtos.School.Student;
using Entity.Dtos.School.Tution;
using Entity.Model.School;

namespace Business.Interfaces.Querys
{
    public interface IQueryTutionServices : IQueryServices<Tuition, TutionDto>
    {
        Task<IEnumerable<StudentDto>> GetStudentDegree(int idDegree);
    }
}
