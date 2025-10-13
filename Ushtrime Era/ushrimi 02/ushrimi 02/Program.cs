//3- Lexo numra derisa përdoruesi të shkruajë 0
int num;
Console.Write("Shkruaj 1 numer:");
int.TryParse(Console.ReadLine(), out num);
while (num != 0)
{
    Console.WriteLine("Numri eshte: " + num);
    Console.Write("jep nje nr te ri: ");
    int.TryParse(Console.ReadLine(), out num);

}


//5- gjej shumën e shifrave të një numri
//Console.Write("jepni nje nr: ");
//int.TryParse(Console.ReadLine(), out int num);
//int sum = 0;
//while (num != 0)
//{
//    sum += num % 10;
//    num /= 10;
//}
//Console.WriteLine("Shuma e shifrave eshte: " + sum);



