using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeuMangaAqui.Models
{
    [Table("Favorite")]
    public class Favorite
    {
        [Key]
        public Guid Id { get; set; }



        // Atribuido ID do Usuário
        public Guid UserId { get; set; }
        public virtual User User { get; }

    }
}
