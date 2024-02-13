using FluentValidation;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Validators
{
    public class MangaValidator : AbstractValidator<Manga>
    {
        public MangaValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .NotNull()
                .WithMessage("Favor inserir um Nome");

            RuleFor(x => x.Author).NotEmpty()
                .NotNull()
                .WithMessage("O campo Author não pode ficar vazio");

            RuleFor(x => x.Description).NotEmpty()
                .NotNull()
                .WithMessage("O campo descrição não pode ficar vazio");

            RuleFor(x => x.ReleaseDate).NotEmpty()
                .NotNull();

            RuleFor(x => x.Type).NotNull();

            RuleFor(x => x.Status).NotNull();

            RuleFor(x => x.Genres).NotNull();

        }
    }
}
