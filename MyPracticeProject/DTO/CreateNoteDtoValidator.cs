using FluentValidation;
using MyPracticeProject.DTO;

namespace MyPracticeProject.DTO
{
    public class CreateNoteDtoValidator : AbstractValidator<CreateNoteDto>
    {
        public CreateNoteDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Заголовок обов'язковий")
                .MinimumLength(3).WithMessage("Мінімум 3 символи");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Зміст обов'язковий")
                .MinimumLength(5).WithMessage("Мінімум 5 символів");
        }
    }
}
