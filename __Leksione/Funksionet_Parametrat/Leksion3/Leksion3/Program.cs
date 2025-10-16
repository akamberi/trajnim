void AfishoMenu()
{
    Console.WriteLine("+: Mbledhje");
    Console.WriteLine("-: Zbritje");
    Console.WriteLine("*: Shumezim");
    Console.WriteLine("/: Pjestim");
    Console.WriteLine("d: Dil");
}

int LexoNumer()
{
    Console.Write("Jep nje numer: ");
    if (!int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine("Vendos nje numer te sakte!!!");
        return LexoNumer();//therret vetveten
    }
    return value;
}

double BejVeprim(string veprimi, int nr1, int nr2)
{
    switch (veprimi)
    {
        case "+":
            return nr1 + nr2;
        case "-":
            return nr1 - nr2;
        case "*":
            return nr1 * nr2;
        case "/":
            if (nr2 == 0)
            {
                Console.WriteLine("Nuk lejohet pjestimi me 0");
                return 0;
            }
            return (double)nr1 / nr2;
    }
    return 0;
}

do
{
    Console.Clear();
    AfishoMenu();
    string choice = Console.ReadLine();
    if (!(new string[] { "+", "-", "*", "/", "d" }).Contains(choice))
    {
        Console.WriteLine("Zgjedhje jo e sakte, shtyp nje buton per te provuar perseri");
        Console.ReadKey();
        continue;
    }
    if (choice == "d")
    {
        Console.WriteLine("Faleminderit qe zgjodhet makinen tone llogaritese");
        break;
    }
    int nr1 = LexoNumer();
    int nr2 = LexoNumer();
    double res = BejVeprim(choice, nr1, nr2);
    Console.WriteLine($"Rezultati: {res}");
    Console.ReadKey();
} while (true);