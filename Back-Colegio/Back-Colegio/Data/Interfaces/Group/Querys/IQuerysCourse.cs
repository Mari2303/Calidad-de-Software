using Entity.Model.School;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz de extension de user rol
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerysCourse : IQuerys<Course>
    {
        Task<Course?> QueryCourseWithStudentsAsync(int courseId);
        Task<IEnumerable<Course>?> QueryCourseDegree(int courseId);
    }
}