using Entity.Dtos.School.Period;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class PeriodDtoValidator : AbstractValidator<PeriodDto>
    {
        public PeriodDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
