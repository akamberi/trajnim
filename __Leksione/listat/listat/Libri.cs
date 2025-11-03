public class Libri
{
    public string Titulli { get; set; }
    public string Autori { get; set; }
    public int Viti { get; set; }
    public static void Afisho(List<Libri> librat)
    {
        foreach (Libri libri in librat)
        {
            if (libri.Viti > 2015)
            {
                Console.WriteLine(libri.Titulli);
            }
        }
    }
}
