Console.Write("jep shumefishin : ");
int shumefish = int.Parse(Console.ReadLine());
Console.Write("jep nje numrin : ");
int.TryParse(Console.ReadLine(), out int numri);
if (shumefish % numri == 0)
{
    Console.WriteLine("eshte shumefish");
}
else
{
    Console.WriteLine("nuk eshte shumefish");
}
