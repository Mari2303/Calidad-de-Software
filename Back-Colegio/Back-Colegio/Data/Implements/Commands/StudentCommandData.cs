using Data.Implements.Commands;
using Data.Interfaces.Group.Commands;
using Entity.Context.Main;
using Entity.Model.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Command
{
    public class StudentCommandData : BaseGenericCommandsData<Student>, ICommandStuden
    {
        protected readonly ILogger<StudentCommandData> _logger;
        protected readonly AplicationDbContext _context;

        public StudentCommandData(AplicationDbContext context, ILogger<StudentCommandData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public virtual async Task<bool> UpdateStudentCourseAsync(int studentId, int newCourseId)
        {
            var rows = await _context.Students
                .Where(s => s.Id == studentId)
                .ExecuteUpdateAsync(up => up
                    .SetProperty(s => s.CourseId, newCourseId));

            return rows > 0; 
        }








    }
}
