using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeuMangaAqui.Models
{
    [Table("Chapter")]
    public class Chapter
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<byte> ChaptherPics { get; set; }
        public DateTime Posted { get; set; }

        public Guid MangaId { get; set; }
        public virtual Manga Manga { get; set; }
    }
}
