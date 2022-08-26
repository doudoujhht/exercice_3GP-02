// See https://aka.ms/new-console-template for more information
using exercice2;
Console.WriteLine("Hello, World!");
Carre carre = new(20);
Rectangle rectangle = new(12, 8);
Cercle cercle = new(0);
Console.WriteLine(carre.CalculerPerimetre());
Console.WriteLine(rectangle.CalculerPerimetre());
Console.WriteLine(cercle.CalculerPerimetre());
