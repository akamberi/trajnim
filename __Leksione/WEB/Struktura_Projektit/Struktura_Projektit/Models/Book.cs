using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Struktura_Projektit.Models
{
    public class BookAddDTO : IValidatableObject
    {
        [Required(ErrorMessage = "Vendos titullin")]
        [StringLength(100, ErrorMessage = "Titulli duhet te jete me pak ose 100 karaktere", MinimumLength = 5)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Vendos titullin")]
        [StringLength(100, ErrorMessage = "Titulli duhet te jete me pak ose 100 karaktere", MinimumLength = 5)]
        public string Authori { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Price < 0)
                yield return new ValidationResult("Cmimi smund te jete vlere negative", new string[]
                {
                    "Price"
                });
        }
    }

    public class Book
    {
        public static int _id = 0;
        public Book()
        {
            this.Id = ++_id;
        }

        [DisplayName("ID Unike")]
        [Key]
        public int Id { get; }

        [DisplayName("Titulli")]
        public string Title { get; set; }

        [DisplayName("Autori")]
        public string Author { get; set; }

        [DisplayName("Cmimi")]
        public decimal Price { get; set; }
    }
}
