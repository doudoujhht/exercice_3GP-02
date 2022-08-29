using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Carre : Rectangle
    {
        public double Cote { get; }
        public Carre(double cote):base(cote,cote)
        {
            this.Cote = cote;
        }
        public new void DessinerObjet()
        {
            Console.WriteLine("voici le carré");

            for (int i = 0; i < Math.Ceiling(Longueur); i++)
            {
                for (int j = 0; j < Math.Ceiling(Largeur); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
