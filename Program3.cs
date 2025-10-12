
        int numer;
// kur perdoruesi shtyp numrin zero programi ndalet
        Console.Write("Shkruaj një numër : ");
        numer = int.Parse(Console.ReadLine());

        while (numer != 0)
        {
            Console.Write("Shkruaj një tjetër numër : ");
            numer = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Programi përfundoi.");
    

