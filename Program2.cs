using System;

class Program
{
    static void Main()
    {
      Console.Write("shkruani moshen tuaj: ");
        int mosha =int.Parse(Console.ReadLine());

        if (mosha > 18)
        {
            Console.WriteLine("Ju keni te drejt te votoni");
        }
        else
        {
            Console.WriteLine("Ju nuk mund te votoni");
        }
    }
}