using Entity.Dtos.School.CourseHall;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class CourseHallDtoValidator : AbstractValidator<CourseHallDto>
    {
        public CourseHallDtoValidator()
        {
            RuleFor(x => x.CourseId)
           .NotEmpty().WithMessage("El id del curso es obligatorio");

        }
    }
}
