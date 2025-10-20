void rendrites(int a , int b)
{
    if (a > b)
        Console.WriteLine(a + " " + b);
    else
        Console.WriteLine(b + " " + a);
}
Console.Write("ju lutem shkruani numrin e pare: ");
 int nr1 = int.Parse(Console.ReadLine());
Console.Write("ju lutem shkruani numrin e dyte: ");
int nr2 = int.Parse(Console.ReadLine());

rendrites(nr1, nr2);