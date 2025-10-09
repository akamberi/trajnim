using System;

class Program
{
    static void Main()
    {
        Console.Write("Shkruaj figurën (katror, drejtkendesh, rreth): ");
        string figura = Console.ReadLine().ToLower();

        switch (figura)
        {
            case "katror":
                Console.WriteLine("Formula për sipërfaqen: S = a * a");
                break;
            case "drejtkendesh":
                Console.WriteLine("Formula për sipërfaqen: S = a * b");
                break;
            case "rreth":
                Console.WriteLine("Formula për sipërfaqen: S = π * r * r");
                break;
            default:
                Console.WriteLine("Figurë e panjohur.");
                break;
        }
    }
}

