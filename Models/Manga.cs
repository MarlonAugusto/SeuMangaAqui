using SeuMangaAqui.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeuMangaAqui.Models
{
    [Table("Manga")]
    public class Manga
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public MangaType Type { get; set; } // Puxar tipo do manga
        public Status Status { get; set; } // Puxar qual Status
        public List<Genre> Genres { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public DateTime ReleaseDate { get; set; } // Data inicial de lançamento
        public DateTime? EndDate { get; set; } // Data de final/abandonado

        public Chapter Chapter { get; set; }

    }
    
}
