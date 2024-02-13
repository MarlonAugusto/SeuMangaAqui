using FluentValidation;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Validators
{
    public class ReadingValidator : AbstractValidator<Reading>
    {
        public ReadingValidator()
        {
            RuleFor(r => r.UserId).NotNull();
            RuleFor(r => r.ChapterId).NotNull();
            RuleFor(r => r.Progress).NotNull().InclusiveBetween(0, 100);
        }
    }
}
