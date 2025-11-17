using static System.Reflection.Metadata.BlobBuilder;

namespace Struktura_Projektit.Models
{
    public static class AuthorManager
    {
       static  List<Author> authors = new List<Author>()
        {
            new Author
            {
                 Birthplace ="Fier",
                 Name="Era",
            },
            new Author
            {
                 Birthplace ="Tr",
                 Name="Marjo",
            },
            new Author
            {
                 Birthplace ="Diber",
                 Name="Afrim",
            },
        };
        public static List<Author> GetAuthors()
        {
            return authors;
        }

        public static void AddAuthor (Author author)
        {
           authors.Add(author);
        }
    }

}
