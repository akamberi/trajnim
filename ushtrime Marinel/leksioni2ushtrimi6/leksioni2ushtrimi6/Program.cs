Console.Write("jep emrin figures gjeometrike: ");
string fig = Console.ReadLine();
switch (fig)
{
    case "katror":
        Console.WriteLine("siperfaqa = a * a");
        Console.WriteLine("perimetri = 4 * a");
        break;
    case "rreth":
        Console.WriteLine("siperfaqa = pi * (r * r) ");
        Console.WriteLine("perimetri = 2 * pi * r");
        break;
    case "drejtkendesh":
        Console.WriteLine("perimetri = 2 * (gjatesi + gjeresi) ");
        Console.WriteLine("siperfaqa = gjatesi * gjeresi ");
        break;
    default:
        Console.WriteLine("e panjohur");
        break;
}