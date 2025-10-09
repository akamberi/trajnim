using System;   

class Program
{
    static void Main()
    {
       Console.Write("shkruani numrin e pare: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("shkruani numrin e dyte: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("shkruani numrin e trete: ");
        double n3 = double.Parse(Console.ReadLine());

        double mesatarja = (n1 + n2 + n3) / 3;

        Console.WriteLine($"mesatarja eshte: {mesatarja}");

        if (mesatarja >10)
            
            Console.WriteLine("mesatarja eshte me e madhe se 10");
            else
            Console.WriteLine("mesatarja eshte me e vogel se 10");

    }
}