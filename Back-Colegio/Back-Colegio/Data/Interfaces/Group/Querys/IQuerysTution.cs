using Entity.Model.School;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz de extension de user rol
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerysTution : IQuerys<Tuition>
    {
        Task<IEnumerable<Tuition>> QueryByStudenGrade(int courseId);
    }
}