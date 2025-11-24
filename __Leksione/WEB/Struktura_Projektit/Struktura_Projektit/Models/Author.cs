using System.ComponentModel.DataAnnotations;

namespace Struktura_Projektit.Models
{
    public class AuthorDTO
    {
        [Required(ErrorMessage = "Vendos emrin e autorit")]
        [StringLength(100, ErrorMessage = "Emri duhet te jete me pak ose 100 karaktere", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vendos vendlindjen e autorit")]
        [StringLength(100, ErrorMessage = "Vendlindja duhet te jete me pak ose 100 karaktere", MinimumLength = 3)]
        public string Birthplace { get; set; }

    }
    public class Author
    {
        public static int _id = 0;
        public Author()
        {
            this.Id = ++_id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string Birthplace { get; set; }
    }
}
