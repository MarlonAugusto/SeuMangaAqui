using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeuMangaAqui.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string UserAccount { get; set; }
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime LastLogin { get; set; }
        
        //Atribuindo Favorito
        public int FavoriteId { get; set; }
        public virtual Favorite Favorite { get; set; }
    }


}
