void shumzome3(ref int num)
{
    num = num * 3;
}
Console.Write("shkruani numrin:");
    int x  =int.Parse(Console.ReadLine());

shumzome3(ref x);
 Console.WriteLine("numri u shumzuar eshte:" + x );