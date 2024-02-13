using Microsoft.EntityFrameworkCore;
using SeuMangaAqui.Models;

namespace SeuMangaAqui.Persistence
{
    public class MangaDbContext : DbContext
    {
        public MangaDbContext(DbContextOptions<MangaDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Manga> Manga { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Reading> Readings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
