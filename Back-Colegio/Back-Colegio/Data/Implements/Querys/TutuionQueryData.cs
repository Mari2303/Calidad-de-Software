using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Querys.Security
{
    public class TutuionQueryData : BaseGenericQuerysData<Tuition>, IQuerysTution
    {
        protected readonly ILogger<TutuionQueryData> _logger;
        protected readonly AplicationDbContext _context;

        public TutuionQueryData(AplicationDbContext context, ILogger<TutuionQueryData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        // Metodo que sirve como consulta de que estudiantes tiene 
        public virtual async Task<IEnumerable<Tuition>> QueryByStudenGrade(int courseId)
        {
            try
            {
                var course = await _context.Tuitions
                    .AsNoTracking()
                    .Where(c => c.DegreeId == courseId)
                    .Include(c => c.Student)
                    .ToListAsync();

                _logger.LogInformation("Consulta de {Entity} realizada", typeof(Tuition).Name);
                return course; // puede ser null si no existe
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error consultando {Entity}", typeof(Tuition).Name);
                throw;
            }
        }

    }
}
