using SeuMangaAqui.Enums;

namespace SeuMangaAqui.Models
{
    public class Manga
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public MangaType Type { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
        public virtual ICollection<Reading> Leituras { get; set; }
    }

}
