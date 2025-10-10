// Ky program kontrollon nese nje numer eshte shumefish i 3 dhe 5

using System;

class Program
{
    static void Main()
    {
        Console.Write("Jep nje numer: ");
        int numri = int.Parse(Console.ReadLine());

        if (numri % 3 == 0 && numri % 5 == 0)
        {
            Console.WriteLine("Numri eshte shumefish i 3 dhe 5.");
        }
        else
        {
            Console.WriteLine("Numri nuk eshte shumefish i 3 dhe 5.");
        }
    }
}
