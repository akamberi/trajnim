namespace Struktura_Projektit.Models
{
    public class AuthorDTO
    {
        public string Name { get; set; }
        public string Birthplace {  get; set; }

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
