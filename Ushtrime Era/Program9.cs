
  int[] numra = { 3, 5, 7, 9 };
  Console.WriteLine("Shuma është: " + Shuma(numra));
  
    static int Shuma(int[] numra)
    {
        int s = 0;
        for (int i = 0; i < numra.Length; i++)
            s += numra[i];
        return s;
    }