using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Usuário e Leituras (muitos para muitos)
            builder.HasMany(u => u.Readings)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            // Usuário e Favoritos (muitos para muitos)
            builder.HasMany(u => u.Favorites)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.UserId);
        }
    }
}
