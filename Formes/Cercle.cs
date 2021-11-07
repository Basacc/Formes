using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Cercle : Forme
    {
        double rayon;

        public double Rayon { get => rayon; set => rayon = value; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public Cercle(double rayon, int x, int y)
        {
            Rayon = rayon;
            PositionX = x;
            PositionY = y;
        }

        public override double getPerimetre()
        {
            return Math.PI * (Rayon * 2);
        }

        public override double getSurface()
        {
            return Math.PI * Rayon * Rayon;
        }
    }
}
