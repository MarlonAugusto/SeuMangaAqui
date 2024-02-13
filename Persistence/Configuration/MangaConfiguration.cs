using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Persistence.Configuration
{
    public class MangaConfiguration : IEntityTypeConfiguration<Manga>
    {
        public void Configure(EntityTypeBuilder<Manga> builder)
        {
            // Mangá e Gêneros (muitos para muitos)
            builder.HasMany(m => m.Genres)
                .WithMany(g => g.Mangas)
                .UsingEntity(j => j.ToTable("MangaGenre"));

            // Mangá e Capítulos (um para muitos)
            builder.HasMany(m => m.Chapters)
                .WithOne(c => c.Manga)
                .HasForeignKey(c => c.MangaId);
        }
    }
}
