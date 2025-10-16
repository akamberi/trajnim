//////detyra  e shtepise
////Console.WriteLine("jeo numrin e rreshtave:");
////int.TryParse(Console.ReadLine(), out int n);

////for (int i = 1; i <= n; i++)
////{
////    for (int j = 1; j <= n - i; j++)
////    {
////        Console.Write(" ");
////    }
////    for (int k = 1; k <= (2 * i - 1); k++)
////    {
////        Console.Write("*");
////    }
////    Console.WriteLine();
////}


////Listat
////Krijo nje list me n elemente , pyet perdoruesin per nje vlere dhe hiq vleren nga lista
//List<int> list = new List<int>();
//Console.WriteLine("jep numrin e elementeve: ");
//int.TryParse(Console.ReadLine(), out int n);
//for (int zh = 0; zh < n; zh++)
//{
//    Console.Write("jep nje numer: ");
//    int.TryParse(Console.ReadLine(), out int numri);
//    list.Add(numri);
//}
//Console.Write("jep vleren: ");
//int.TryParse(Console.ReadLine(), out int vlera);
//for (int j = 0; j < n; j++)
//{
//    if (list[j] == vlera)
//    {
//        list[j] = 2 * vlera;
//    }
//}
//foreach(int d in list)
//{
//    Console.WriteLine(d);
//}

//funksionet
//<tipi_i_kthimit> < emri_metodes > ()
//{
//  //blloku qe do te ekzektuohet
//}

//pa parametra
//void Pershendetje()
//{
//    Console.WriteLine("Pershendetje!");
//}

//Pershendetje();

//me parametra
//void Pershendetje(string name)
//{
//    Console.WriteLine("Pershendetje " + name + "!");
//}

//Pershendetje("Kristi");

//void AfishoShumen(int a, int b)
//{
//    Console.WriteLine(a + b);
//}

//AfishoShumen(5, 7);
//AfishoShumen(13, 24);
//AfishoShumen(1320, 450);

//Parametrat me vlere 
//void NdryshoNr(int x)
//{
//    Console.WriteLine($"78: {x}");
//    x = x + 10;
//    Console.WriteLine($"80: {x}");
//}
//void NdryshoNrMeReference(ref int x)
//{
//    Console.WriteLine($"84: {x}");
//    x = x + 10;
//    Console.WriteLine($"86: {x}");
//}

//int n = 5;
//Console.WriteLine($"90: {n}");
//NdryshoNr(n);
//Console.WriteLine($"92: {n}");
//NdryshoNrMeReference(ref n);
//Console.WriteLine($"94: {n}");

//Parametrat out 
//void MerrVlere(out int x)
//{
//    x = 10;
//}
//int num;
//MerrVlere(out num);
//Console.WriteLine(num);

//void PjestimiAndMbetja(int a, int b, out int heresi, out int mbetja)
//{
//    heresi = a / b;
//    mbetja = a % b;
//}

//int a = 10;
//int b = 5;
//int q;
//int p;
//PjestimiAndMbetja(a, b, out q, out p);
//Console.WriteLine("Heresi: " + q);
//Console.WriteLine("Mbetja: " + p);

//Parametri in 
//void Shfaq(in int x)
//{
//    Console.WriteLine(x);
//}
//int x = 10;
//Shfaq(in x);

//Params 
//void Shuma(params int[] numra)
//{
//    int shuma = 0;
//    foreach(int i in numra)
//    {
//        shuma = shuma + i;
//    }
//    Console.WriteLine(shuma);
//}
//Shuma();
//Shuma(5, 10, 15);
//Shuma(3, 67, 87, 135, 3056, 765);

//opsionale
//void Pershendetje(string name = "Kristi")
//{
//    Console.WriteLine(name);
//}

//Pershendetje(); //merr vleren default kristi
//Pershendetje("Era"); // merr vleren e dhene

//te emertuar
//void InfoStudent(string emer, int mosha, string qyteti)
//{
//    Console.WriteLine($"{emer}, {mosha} vjec, nga {qyteti}");
//}
//InfoStudent("afrim", 22, "tirana"); //sipas rradhes 
//InfoStudent(qyteti: "Tirana", mosha: 23, emer: "Afrim");