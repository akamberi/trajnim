//nje klase produkt e cila do ket emer,cmim dhe sasi
//krijo nje list produkt qe do sherbej si iventar do krijojm metodat:
// 1 shto produkt
// 2 fshi produkt ne baze te emrit
// 3 totali i produkteve qe do kthej shumen e stokut qe ka
using ConsoleApp26;

var dyqan = new Dyqan();    
dyqan.ShtoProdukt(new Produkt { emri = "Molle", cmimi = 100, sasi = 50 });
dyqan.ShtoProdukt(new Produkt { emri = "Dardhe", cmimi = 150, sasi = 30 });
dyqan.ShtoProdukt(new Produkt { emri = "Banane", cmimi = 200, sasi = 20 });
foreach (var produkt in dyqan.Produktet)
{
    Console.WriteLine($"Emri: {produkt.emri}, Cmimi: {produkt.cmimi}, Sasia: {produkt.sasi}");
}
Console.WriteLine("Totali i produkteve: " + dyqan.TotaliProdukteve());
dyqan.FshiProdukt("Dardhe");
Console.WriteLine("Produkti 'Dardhe' u fshi.");
Console.WriteLine("Totali i produkteve pas fshirjes: " + dyqan.TotaliProdukteve());