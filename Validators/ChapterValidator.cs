using FluentValidation;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Validators
{
    public class ChapterValidator : AbstractValidator<Chapter>
    {
        public ChapterValidator()
        {
            RuleFor(x => x.Title).NotEmpty()
                .NotNull()
                .WithMessage("Capitulo precisa do Título");
        }
    }
}
