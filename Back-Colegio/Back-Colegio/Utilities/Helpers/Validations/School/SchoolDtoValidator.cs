using Entity.Dtos.School.Grade;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class SchoolDtoValidator : AbstractValidator<SchoolDto>
    {
        public SchoolDtoValidator()
        {
            RuleFor(x => x.NameSchool)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
