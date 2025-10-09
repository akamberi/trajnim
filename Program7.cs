using System;

class Program
{
    static void Main()
    {
        Console.Write("Shkruaj moshën: ");
        int mosha = int.Parse(Console.ReadLine());

        if (mosha >= 0 && mosha <= 12)
            Console.WriteLine("Fëmijë");
        else if (mosha >= 13 && mosha <= 17)
            Console.WriteLine("Adoleshent");
        else if (mosha >= 18 && mosha <= 64)
            Console.WriteLine("I rritur");
        else if (mosha >= 65)
            Console.WriteLine("I moshuar");
        else
            Console.WriteLine("Moshë e pavlefshme.");
    }
}
