
Console.Write("jep numrin a : ");
int a = int.Parse(Console.ReadLine());
Console.Write("jep mumrin b : ");
int b = int.Parse(Console.ReadLine());
Console.Write("jep numrin c : ");
int c = int.Parse(Console.ReadLine());
int mesatarja = (a + b + c) / 3;
Console.WriteLine("mesatarja eshte : " + mesatarja);
if (mesatarja > 10)
{
    Console.WriteLine("mesatarja eshte me madhe se 10 ");
}
else
{
    Console.WriteLine("mesatarja eshte me e vogle se 10");
}
