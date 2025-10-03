using Entity.Dtos.School.Course;
using Entity.Model.School;

namespace Business.Interfaces.Querys
{
    public interface IQueryCourseServices : IQueryServices<Course, CourseDto>
    {
        Task<CoursesStudentsDto> GetStudentCourse(int CourseId);
    }
}
