using FluentValidation;
using FluentValidation.Validators;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty()
                .NotNull()
                .WithMessage("Email é obrigatório")
                .EmailAddress(EmailValidationMode.Net4xRegex);

            RuleFor(x => x.Password).NotEmpty()
                .NotNull()
                .WithMessage("A senha é obrigatória");
        }
    }
}
