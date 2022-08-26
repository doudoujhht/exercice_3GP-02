// See https://aka.ms/new-console-template for more information
using exercice_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Livre Livre1 = new("Game Engine Architecture 3rd ed.", "Jason Grogory", "Crc Press", 1200, 2018);
        Livre Livre2 = new("Python for Data analysis 2nd ed.", "Wes McKinney", "O'Reilly", 523, 2017);

        Console.WriteLine(Livre1);
        Console.WriteLine(Livre2);

    }
}