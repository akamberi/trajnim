// See https://aka.ms/new-console-template for more information
Console.Write("jep nje numrin : ");
int.TryParse(Console.ReadLine(), out int numri);
if (numri / 5 == 1)
{
    Console.WriteLine("plotepjestohet me 5");
}
else
{
    Console.WriteLine(" nuk plotepjestohet me 5");
}
