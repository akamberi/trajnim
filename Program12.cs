
        List<double> nota = new List<double>() { 8.5, 7.8, 10.0, 4.5, 8.2 };

        double max = double.MinValue;
        double min = double.MaxValue;

        foreach (double n in nota)
        {
            if (n > max) max = n;
            if (n < min) min = n;
        }

        Console.WriteLine("Nota më e lartë: " + max);
        Console.WriteLine("Nota më e ulët: " + min);
    