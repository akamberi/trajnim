public class PrintedBook : Book
{
    public int NumriFaqeve { get; set; }

    public PrintedBook(string titulli, string autori, double cmimi, int nrFaqesh)
        : base(titulli, autori, cmimi)
    {
        NumriFaqeve = nrFaqesh;
    }
    public override void ShfaqInfo()
    {
        Console.WriteLine($"PrintedBook: Titulli: {Titulli}, Autori: {Autori} , Cmimi: {Cmimi} , NrF: {NumriFaqeve}");
    }
}