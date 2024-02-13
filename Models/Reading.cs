namespace SeuMangaAqui.Models
{
    public class Reading
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid MangaId { get; set; }
        public virtual Manga Manga { get; set; }

        public int Progress { get; set; }

        public Guid ChapterId { get; set; }
        public virtual Chapter Chapter { get; set; }

        public bool IsRead { get; set; }
    }

}
