using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeuMangaAqui.Models
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public DateTime PostedAt { get; set; }
        public Guid MangaId { get; set; }
        public virtual Manga Manga { get; set; }
        public ICollection<Reading> Readings { get; set; }
        public Reading Reading { get; set; }

    }
}
