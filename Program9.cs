
        int[] numra = { 2, 5, 3, 5, 7, 5, 1, 2, 5, 4 };

        Console.Write("Shkruaj numrin që do kërkosh: ");
        int target = int.Parse(Console.ReadLine());
        int count = 0;

        foreach (int n in numra)
            if (n == target)
                count++;

        Console.WriteLine($"Numri {target} përsëritet {count} herë në array.");
    