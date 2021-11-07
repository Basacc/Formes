using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Carre : Forme
    {
        double cote;
        public double Cote { get => cote; set => cote = value; }

        public Carre(double cote)
        {
            this.Cote = cote;
        }

        public Carre( double cote, int x, int y)
        {
            this.Cote = cote;
            this.PositionX = x;
            this.PositionY = y;
        }

        public override double getPerimetre()
        {
            return Cote * 4;
        }

        public override double getSurface()
        {
            return Cote * Cote;
        }
    }
}
