
        List<int> numra = new List<int>() { 5, 12, 7, 20, 9, 15 };
        numra.RemoveAll(n => n <10);

        Console.WriteLine("Lista pas heqjes:");
        foreach (int n in numra)
            Console.WriteLine(n);
    