namespace OOP
{
    public class Libri
    {
        public string Titulli {  get; set; }
        public string Autori { get; set; }
        
        public Libri() 
        {
            Titulli = "i panjohur";
            Autori = "i panjohur";
        }

        public Libri(string titulli, string autori)
        {
            Titulli = titulli;
            Autori = autori;
        }
    }
}
