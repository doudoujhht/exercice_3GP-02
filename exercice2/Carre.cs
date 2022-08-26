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
    }
}
