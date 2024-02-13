using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Persistence.Configuration
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            // Relacao Leitura Capitulo (muitos para muitos)
            builder.HasOne(c => c.Manga)
              .WithMany(m => m.Chapters)
              .HasForeignKey(c => c.MangaId);

        }
    }
}
