using Entity.Dtos.School.Degree;
using Entity.Dtos.School.Grade;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class GradeDtoValidator : AbstractValidator<GradeDto>
    {
        public GradeDtoValidator()
        {
            RuleFor(x => x.PeriodId)
           .NotEmpty().WithMessage("El periodo es obligatorio");

        }
    }
}
