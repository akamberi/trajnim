
    
        int[] numra = { 15, 8, 2,5, 12, 2,55, 4 };
        int min = numra[0];

        foreach (int n in numra)
            if (n < min)
                min = n;

        Console.WriteLine("Numri më i vogël është: " + min);
    