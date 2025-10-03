using Entity.Dtos.School.Hall;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class HallDtoValidator : AbstractValidator<HallDto>
    {
        public HallDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
