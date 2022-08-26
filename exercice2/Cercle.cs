using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Cercle : FormeGeometrique
    {
        private double Rayon { get; }


        public Cercle(double rayon)
        {
            try
            { 
                if (rayon <= 0)
                {
                    throw new ArgumentException();
                }
                Rayon = rayon;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("le rayon doit etre plus grand que zero");
            }
        }

        override public double CalculerPerimetre()
        {
            return (Rayon * 2) * Math.PI;
        }

    }
}
