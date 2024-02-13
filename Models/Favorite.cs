using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeuMangaAqui.Models
{
    public class Favorite
    {
        public Guid Id { get; set; }

        public Guid MangaId { get; set; }
        public virtual Manga Manga { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
