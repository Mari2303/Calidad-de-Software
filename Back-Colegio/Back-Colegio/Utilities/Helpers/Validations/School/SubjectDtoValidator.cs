using Entity.Dtos.School.Subject;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class SubjectDtoValidator : AbstractValidator<SubjectDto>
    {
        public SubjectDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
