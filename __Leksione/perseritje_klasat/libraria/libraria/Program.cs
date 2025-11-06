/*Krijo nje klase baze Book qe do te kete : Titulli, autori, cmimi
Krijo dy klasa qe do te trashegojne : PrintedBook(numrin e faqeve), EBook(FileSizeMB)
Krijo nje list librash dhe mbush me objekte
Krijo nje metode qe shfaq te gjithe librat me cmim mbi nje vlere te dhene nga perdoruesi
Krijo nje metode qe llogarit totalin e vleres se librave ne liste*/
List<Book> librat = new List<Book>();
librat.Add(new PrintedBook("kadare", "veprat", 3000, 450));
librat.Add(new PrintedBook("ismail", "stuhia", 6000, 320));

librat.Add(new EBook("kadare", "veprat", 3000, 20.5));
librat.Add(new EBook("ismail", "stuhia", 6000, 15.5));

Console.WriteLine("librat jane:");
foreach (Book book in librat)
{
    book.ShfaqInfo();
}

Console.WriteLine("vendos cmimin:");
double.TryParse(Console.ReadLine(), out double cm);
ShfaqLibraMbiCmimin(librat, cm);

double result = LlogaritTotalin(librat);
Console.WriteLine($"Totali i cmimeve te librave eshte:{result}");

void ShfaqLibraMbiCmimin(List<Book> librat, double cmimi)
{
    var lb = librat.Where(x => x.Cmimi > cmimi);
    foreach (var book in lb)
    {
        book.ShfaqInfo();
    }
}
double LlogaritTotalin(List<Book> librat)
{
    return librat.Sum(x => x.Cmimi);
}