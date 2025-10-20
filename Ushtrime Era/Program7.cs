
    {
        double[] numra = { 4, 6, 10, 8 };
        Console.WriteLine("Mesatarja është: " + Mesatarja(numra));
    }
    static double Mesatarja(double[] numra)
    {
        double shuma = 0;
        for (int i = 0; i < numra.Length; i++)
            shuma += numra[i];
        return shuma / numra.Length;
    }
