string input;

do
{
    Console.Write("Shkruaj një fjalë : ");
    input = Console.ReadLine().Trim().ToLower(); 

} while (input != "stop");

Console.WriteLine("Programi përfundoi!");
    