using Entity.Model.School;

namespace Data.Interfaces.Group.Commands
{
    public interface ICommandStuden : ICommands<Student>
    {

        Task<bool> UpdateStudentCourseAsync(int studentId, int newCourseId);


    }
}
