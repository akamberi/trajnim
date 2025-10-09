using System;

class Program
{
    static void Main()
    {
        Console.Write("shkruani numrin e pare: ");
        int a= int.Parse(Console.ReadLine());
        Console.Write("shkruani numrin e dyte: ");
        int b = int.Parse(Console.ReadLine());

        if(b !=0 && a%b == 0)
            Console.WriteLine($"{a} eshte shumfish i {b}");
        else
            Console.WriteLine($"{a} nuk eshte shumfish i {b}");










    }
}