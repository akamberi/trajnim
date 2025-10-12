
    
        int[] numra = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Shkruaj numrin {i + 1}: ");
            numra[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numrat çift janë:");
        foreach (int n in numra)
            if (n % 2 == 0)
                Console.WriteLine(n);
    
