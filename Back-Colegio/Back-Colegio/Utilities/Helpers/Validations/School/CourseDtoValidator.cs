using Entity.Dtos.School.Course;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class CourseDtoValidator : AbstractValidator<CourseDto>
    {
        public CourseDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
