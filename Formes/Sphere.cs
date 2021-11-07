using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Sphere : Volume
    {
        double rayon;

        public double Rayon { get => rayon; set => rayon = value; }

        public Sphere(double rayon)
        {
            Rayon = rayon;
        }

        public Sphere(double rayon, int x, int y, int z)
        {
            Rayon = rayon;
            PositionX = x;
            PositionY = y;
            PositionZ = z;
        }

        public override double getSurface()
        {
            return Math.PI * 4 * Rayon * Rayon;
        }

        public override double getVolume()
        {
            return Math.Pow(Rayon, 3) * (Math.PI * 4f / 3f);
        }
    }
}
