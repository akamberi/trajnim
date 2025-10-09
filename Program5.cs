using System;

class Program
{
    static void Main()
    {
        Console.Write("Shkruaj një numër nga 1 deri në 7: ");
        int dita = int.Parse(Console.ReadLine());

        switch (dita)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Ditë pune.");
                break;
            case 6:
            case 7:
                Console.WriteLine("Fundjavë.");
                break;
            default:
                Console.WriteLine("Numër i pavlefshëm! Shkruaj 1–7.");
                break;
                
        }
    }
}
