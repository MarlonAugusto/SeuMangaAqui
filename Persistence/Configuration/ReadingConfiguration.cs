using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Persistence.Configuration
{
    public class ReadingConfiguration : IEntityTypeConfiguration<Reading>
    {
        public void Configure(EntityTypeBuilder<Reading> builder)
        {
            builder.HasIndex(r => new { r.UserId, r.ChapterId });
            builder.HasIndex(r => r.Progress);
        }
    }
}
