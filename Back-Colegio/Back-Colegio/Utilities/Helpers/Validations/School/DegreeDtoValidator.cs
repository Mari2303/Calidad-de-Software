using Entity.Dtos.School.Degree;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class DegreeDtoValidator : AbstractValidator<DegreeDto>
    {
        public DegreeDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
