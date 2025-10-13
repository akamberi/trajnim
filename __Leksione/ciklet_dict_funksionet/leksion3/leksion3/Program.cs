//for
//for (int i = 10; i < 14; i++)
//{
//    Console.WriteLine(i);
//}

//
//for (int i = 0; i < 100; i+=3)
//{
//    i--;
//   Console.WriteLine(i);

//}

//gjej shumen e n numrave te pare natyrore ku n jepet nga prd


//foreach <=> for

//for (int i = 0; i < array1.Length; i++)
//{
//    var variabel = array1[0];
//}

//foreach (Type variabel in array1)
//{
//    //bllok
//}

//bredh cdo element te listes dhe e afishon
//string[] lng = { "C", "C++" };
//foreach (string l in lng)
//{
//    Console.WriteLine(l);
//}

//llogarit shumen e nr nga lista

//List<int> numrat = new List<int> { 1, 6, 8, 10 };
//int sum = 0;
//foreach (int numr in numrat)
//{
//    sum += numr;
//}
//Console.WriteLine(sum);

//kerkoni nje nr nga perdoruesi qe eshte mbi 1 mln.
//afishoni shumen e gjithe shifrave te atij numri.
//13746823 

//Console.Write("jep numrin: ");
//int n = int.Parse(Console.ReadLine());
//string nstr = n + ""; //i kthejme si string 
//int s = 0; //deklarojme shumen 
//foreach (char c in nstr) //per cdo elemente
//{
//    int nc = int.Parse (c.ToString()); //e ruan ne nc
//    s= s + nc; // ia shtojme cdo element te ruajtur shumes se deklaruar
//}
//Console.WriteLine(s); //afishojme shumen


//tabelen e shumezimit te nr deri ne nje n
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine(i + "*" + j + "=" + (i * j));
    }
    Console.WriteLine();
}

//DSH
//kerkoni nga perdoruesi nje nr n dhe afishoni pemen e krishtlindjeve me aq rreshta sa eshte n.


