using Entity.Dtos.School.Degree;
using Entity.Dtos.School.Student;
using FluentValidation;

namespace Utilities.Helpers.Validations.School
{
    public class StudentDtoValidator : AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(x => x.FirstName)
           .NotEmpty().WithMessage("El nombre es obligatorio");

        }
    }
}
