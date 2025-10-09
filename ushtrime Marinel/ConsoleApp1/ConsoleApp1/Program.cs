Console.Write("Shkruani moshën tuaj: ");
int mosha = int.Parse(Console.ReadLine());

if (mosha >= 0 && mosha <= 12)
{
    Console.WriteLine("Jeni Fëmijë.");
}
else if (mosha >= 13 && mosha <= 17)
{
    Console.WriteLine("Jeni Adoleshent.");
}
else if (mosha >= 18 && mosha <= 64)
{
    Console.WriteLine("Jeni i Rritur.");
}
else if (mosha >= 65)
{
    Console.WriteLine("Jeni i Moshuar.");
}
else
{
    Console.WriteLine("Moshe e pavlefshme!");
}