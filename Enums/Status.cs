using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SeuMangaAqui.Enums
{
    public enum Status
    {
        [Display(Name = "Em Lançamento")]
        Launching = 1,

        [Display(Name = "Pausado")]
        Paused = 2,

        [Display(Name = "Descontinuado")]
        Descontinued = 3,

        [Display(Name = "Finalizado")]
        Finished = 4,

        [Display(Name = "Abandonamos")]
        Abandoned = 5
    }
}
