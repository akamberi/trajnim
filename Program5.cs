Console.Write("shkruaj nje numer : ");
    int numri = int.Parse(Console.ReadLine());
int shuma = 0;

while (numri > 0)
{
    shuma += numri % 10;
    numri /= 10;
}
Console.WriteLine(" shuma e shifrave eshte :" + shuma);