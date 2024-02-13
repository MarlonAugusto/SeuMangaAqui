using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeuMangaAqui.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string UserAccount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; } 
    }


}
