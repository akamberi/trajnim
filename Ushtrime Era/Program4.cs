void rritme1(ref int num)
{
    num =num + 1;
}   
Console.Write(" shkruani nje numer: ");
int a=int.Parse(Console.ReadLine());
rritme1(ref a);
Console.WriteLine("Numri i rritur eshte: " + a);