//6- krijo nje array me 10 numra dhe gjej mesataren e tyre.
//int[] numrat = { 6, 9, 5, 7, 3, 2, 10, 1, 8, 4 };
//int shuma = 0;

//for (int i = 0; i < numrat.Length; i++)
//{
//    shuma += numrat[i];
//}

//double mesatarja = (double)shuma / numrat.Length;
//Console.WriteLine("Mesatarja e nr eshte: " + mesatarja);


//7-lexo 5 nr nga tastiera vendosi nje nje array dhe afisho vetem nr cift.
//int[] numrat = new int[5];
//int index = 0;

//while (index < 5)
//{
//    Console.Write("Shkruaj numrin " + (index + 1) + ": ");
//    string input = Console.ReadLine();

//    if (int.TryParse(input, out int nr))
//    {
//        numrat[index] = nr;
//        index++;
//    }
//    else
//    {
//        Console.WriteLine("Ju lutem shtyp një numër të vlefshëm.");
//    }
//}

//Console.WriteLine("Numrat çift janë:");
//foreach (int nr in numrat)
//{
//    if (nr % 2 == 0)
//    {
//        Console.WriteLine(nr);
//    }
//}

//8-Gjej numrin me te vogel ne nje array.
//int[] array = { 20, 5, 6, -7, 9, 10 };
//int min = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] < min)
//        min = array[i];
//}

//Console.WriteLine("Numri i vogël është: " + min);

//9-Krijo një array me 10 numra dhe numëro sa herë përsëritet një numër i dhënë nga përdoruesi:
//int[] array = { 2, 5, 3, 5, 7, 5, 1, 9, 5, 4 };

//Console.Write("Jep nje numer per te shikuar sa here perseritet: ");
//int target = int.Parse(Console.ReadLine());
//int count = 0;
//foreach (int num in array)
//{
//    if (num == target)
//        count++;
//}

//Console.WriteLine("Numri " + target + " perseritet " + count + " here.");