//parametrat me vlere
//ushtrimi 1
//void Dyfisho(int numri)
//{
//    numri = numri * 2;
//    Console.WriteLine("dyfishi: " + (numri * 2));
//}
//int numri = 5;
//Dyfisho(numri);
//Console.WriteLine("vlera: " + numri);

//ushtrimi 2
//void katror(int numri)
//{
//    numri = numri * numri;
//    Console.WriteLine("katrori: " + numri);
//}
//int numri = 4;
//katror(numri);
//Console.WriteLine("vlera: " + numri);


//ushtrimi 3
//void RendZbrites(int d, int e)
//{
//       if (d < e)
//    {
//        Console.WriteLine("d , e");
//    }
//    else
//    {
//        Console.WriteLine("{e} ,{d}");
//    }
//}
//int d = 7;
//int e = 3;  
//RendZbrites(d, e);
//Console.WriteLine("vlera d: " + d);
//Console.WriteLine("vlera e: " + e);

//parametrat me reference(ref)
//ushtrimi 4
//void Rritja(ref int numri)
//{
//    numri ++;
//}
//int numri = 10;
//Rritja(ref numri);
//Console.WriteLine("vlera : " + numri);


//ushtrimi 6
//void ShumezoMeTre(ref int numri)
//{
//    numri = numri * 3;
//}   
//int numri = 6;
//ShumezoMeTre(ref numri);
//Console.WriteLine("vlera : " + numri);
//Parametrat me out
//ushtrimi 7
//void minmaks(int[] numrat ,out int min, out int max)
//{
//    min = numrat[0];
//    max = numrat[0];
//    foreach (int numri in numrat)
//    {
//        if (numri < min)
//        {
//            min = numri;
//        }
//        if (numri > max)
//        {
//            max = numri;
//        }
//    }
//}
//int[] numrat = { 3, 6, 14, 1, 10 };
//int min, max;
//minmaks(numrat, out min, out max);
//Console.WriteLine("Vlera minimale: " + min);    
//Console.WriteLine("Vlera maksimale: " + max);

//parametri params
//ushtrimi 8
//double Mesatarja(params double[] numrat)
//{
//    double shuma = 0;
//    foreach (double nr in numrat)
//    {
//        shuma += nr;
//    }
//    return shuma / numrat.Length;
//}
//double mesatarja = Mesatarja(4, 32, 5);   
//Console.WriteLine("Mesatarja : " + mesatarja);

//ushtrimi 9
//int shuma(params int[] numrat)
//{
//    int shuma = 0;
//    foreach (int nr in numrat)
//    {
//        shuma += nr;
//    }
//    return shuma;
//}
//int a = shuma(3, 5, 7, 2);
//Console.WriteLine("Shuma : " + a);

