using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SeuMangaAqui.Enums
{
    public enum Genre
    {
        [Display(Name = "Ação")]
        Action = 1,

        [Display(Name = "Artes Marciais")]
        MartialArts = 2,

        [Display(Name = "Aventura")]
        Adventure = 3,

        [Display(Name = "Comedia")]
        Comedy = 4,

        [Display(Name = "Drama")]
        Drama = 6,

        [Display(Name = "Fantasia")]
        Fantasy = 7,

        [Display(Name = "Ficção Científica")]
        ScienceFiction = 8,

        [Display(Name = "Horror")]
        Horror = 9,

        [Display(Name = "Isekai")]
        Isekai = 10,

        [Display(Name = "Jogos")]
        Games = 11,

        [Display(Name = "Magia")]
        Magic = 12,

        [Display(Name = "Mistério")]
        Mystery = 13,

        [Display(Name = "Poderes")]
        Powers = 14,

        [Display(Name = "Psicológico")]
        Psychological = 15,

        [Display(Name = "Romance")]
        Romance = 16,

        [Display(Name = "Sci-Fi")]
        SciFi = 17,

        [Display(Name = "Seinen")]
        Seinen = 18,

        [Display(Name = "Shounen")]
        Shounen = 19,

        [Display(Name = "Sobrenatural")]
        Supernatural = 20,

        [Display(Name = "Vida Escolar")]
        SchoolLife = 21
    }
}
