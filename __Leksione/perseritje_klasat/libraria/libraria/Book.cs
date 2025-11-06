public class Book
{
    public string Titulli { get; set; }
    public string Autori { get; set; }
    public double Cmimi { get; set; }

    public Book(string titulli, string autori, double cmimi)
    {
        Titulli = titulli;
        Autori = autori;
        Cmimi = cmimi;
    }
    public virtual void ShfaqInfo()
    {
        Console.WriteLine($"Autori:{Autori},Titulli{Titulli},Cmimi{Cmimi}");
    }
}
