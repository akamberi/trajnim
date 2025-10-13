using System.Collections.Generic;

//List<string> list2 = new List<string> { "C++", "C" };

//List<string> list = new List<string>();
//list.Add("Java");
//list.AddRange(new string[] { "C#", "JS" });

//list.Remove("C");
//list.RemoveAt(0); //java
//list.RemoveAll(e => e.Equals("C"));//heq te gjithe elementet C
//Console.WriteLine(list[0]); //java

//list[0] = "C++";
//Console.WriteLine(list[0]); //C++

//list.Clear(); //te gjithe elementet i fshin

//string lendaPref = "Matematike"; //deklaron nje variabel string
//list.Add(lendaPref);

//list.Remove(lendaPref); //heq vetem nga lista

//kontrollo nese nje element ndodhet ne nje list
//Console.Write("jep nr e 1:");
//int.TryParse(Console.ReadLine(), out int a);
//Console.Write("jep nr e 2:");
//int.TryParse(Console.ReadLine(), out int b);
//Console.Write("jep nr e 3:");
//int.TryParse(Console.ReadLine(), out int c);

//List<int> numrat = new List<int>();
//numrat.Add(a);
//numrat.Add(b);
//numrat.Add(c);

//Console.Write("jep nje nr prove:");
//int.TryParse(Console.ReadLine(), out int d);

//if (numrat.Contains(d))
//{
//    Console.WriteLine("Ndodhet ne liste");
//}
//else
//{
//    Console.WriteLine("Nuk ndodhet ne liste");
//}

//numrat.Count(); // sa elemente ka lista
//Console.WriteLine("Lista ka :" + numrat.Count);

//rendit ne rendin rrites
//numrat.Sort();
//foreach(int num in numrat)
//{
//    Console.WriteLine(num);
//}

//while - Kontrollo derisa nr i dhene nga perdoruesi te jete <= 5
Console.Write("jepni nje nr:");
int.TryParse(Console.ReadLine(), out int a);
while (a <= 5)
{
    Console.WriteLine("Numri eshte:" + a);
    Console.Write("JEP NUMRIN E RI: ");
    int.TryParse(Console.ReadLine(), out a);
}

//perserit derisa nje vlere e dhene te jete int dhe te plotepjestohet me 5
//Console.Write("jepni nje nr:");
//int a;
//while (!int.TryParse(Console.ReadLine(), out a) || a % 5 != 0)
//{
//    Console.WriteLine("Nuk eshte vlere numerike.");
//    Console.Write("Jepni nje numer: ");
//}

//afishimi i 10 nr te pare cift
//int nr = 2;
//int nrTotal = 10;
//int nrAfishuar = 0;
//while (nrAfishuar < nrTotal)
//{
//    Console.WriteLine(nr);
//    nrAfishuar++;
//    nr = nr + 2;

//}

//do_while - Derisa prd te jap numer pozitiv
//int a;
//do
//{
//    Console.Write("jep nje nr:");
//    int.TryParse(Console.ReadLine(), out a);
//    Console.WriteLine("Do te pranohen nr derisa a te jete negativ");
//}
//while (a <= 0);

//te lexohen emrat e studenteve dhe te ruhen e nje liste, nuk dihet sa eshte nr i studenteve,
//pas cdo emri te pyetet perdoruesi nese do te shtoj nje tjeter

//List<string> students = new List<string>();
//do
//{
//    Console.Write("Jep emrin e studentit: ");
//    students.Add(Console.ReadLine()); //shtojme ne liste emrin
//    Console.Write("Deshironi te jepni emer tjeter? ");

//}
//while (Console.ReadLine() == "PO"); //do perseritet derisa te jap prgj PO


