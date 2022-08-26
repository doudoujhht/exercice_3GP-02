using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Rectangle : FormeGeometrique
    {
        public double Longueur { get; }
        public double Largeur { get; }

        public Rectangle(double longeur, double largeur)
        {
            try
            { 
                if (longeur <= 0 || largeur <= 0)
                {
                    throw new ArgumentException();
                }
                Longueur = longeur;
                Largeur = largeur;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("la longeur et la largeur doivent etre plus grand que 0");
            }
        }

        override public double CalculerPerimetre()
        {
            return (Longueur + Largeur) * 2;
        }
    }
}
