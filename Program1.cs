using System;

class Program
{
    static void Main()
    {
        Console.Write("Shkruaj një numër: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 5 == 0)
            Console.WriteLine("Numri plotpjestohet me pese");
        else
            Console.WriteLine("Numri nuk plotpjestohet me pese");
    }
}