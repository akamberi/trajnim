public class EBook : Book
{
    public double FileSizeMB {  get; set; }

    public EBook(string titulli, string autori, double cmimi, double fileSizeMB)
        : base(titulli, autori, cmimi)
    {
        FileSizeMB = fileSizeMB;
    }
    public override void ShfaqInfo()
    {
        Console.WriteLine($"EBook: Titulli: {Titulli}, Autori: {Autori} , Cmimi: {Cmimi} , filesizeMb: {FileSizeMB}");
    }
}