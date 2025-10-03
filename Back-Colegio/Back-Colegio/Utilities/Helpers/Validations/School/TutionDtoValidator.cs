using Entity.Dtos.School.Tution;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class TutionDtoValidator : AbstractValidator<TutionDto>
    {
        public TutionDtoValidator()
        {
            RuleFor(x => x.StudentId)
            .NotEmpty().WithMessage("El estudiante es obligatorio");

            RuleFor(x => x.DegreeId)
            .NotEmpty().WithMessage("El grado es obligatorio");

            RuleFor(x => x.SchoolId)
            .NotEmpty().WithMessage("El colegio es obligatorio");
        }
    }
}
