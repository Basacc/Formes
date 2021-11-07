using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Cube : Volume
    {
        double cote;

        public double Cote { get => cote; set => cote = value; }

        public Cube(double cote)
        {
            Cote = cote;
        }

        public Cube(double cote, int x, int y, int z)
        {
            Cote = cote;
            PositionX = x;
            PositionY = y;
            PositionZ = z;
        }

        public override double getSurface()
        {
            return (Cote * Cote) * 6;
        }

        public override double getVolume()
        {
            return Cote * Cote * Cote;
        }
    }
}
