
        int numer;

        while (true)
        {
            Console.Write("Shkruaj një numër: ");
            numer = int.Parse(Console.ReadLine());

            if (numer % 2 == 0)
                Console.WriteLine("Numër çift: " + numer);
            else
            {
                Console.WriteLine(" Programi ndërpritet.");
                break;
            }
        }
    