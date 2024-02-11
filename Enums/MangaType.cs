using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SeuMangaAqui.Enums
{
    public enum MangaType
    {
        [Display(Name = "Mangá")]
        Manga = 1, // From JP

        [Display(Name = "Manhwa")]
        Manhwa = 2, // From KR

        [Display(Name = "Manhua")]
        Manhua = 3, // From CH

        [Display(Name = "Webtoon")]
        Webtoon = 4 // Peoples Doing
    }
}
