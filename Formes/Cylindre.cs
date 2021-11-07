using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Cylindre : Volume
    {
        double rayon;
        double hauteur;

        public double Rayon { get => rayon; set => rayon = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }

        public Cylindre(double rayon, double hauteur)
        {
            Rayon = rayon;
            Hauteur = hauteur;
        }

        public Cylindre(double rayon, double hauteur, int x, int y, int z)
        {
            Rayon = rayon;
            Hauteur = hauteur;
            PositionX = x;
            PositionY = y;
            PositionZ = z;
        }

        public override double getSurface()
        {
            return (Math.PI * Rayon * 2) + (Math.PI * Rayon * Hauteur * 2); 
        }

        public override double getVolume()
        {
            return Math.PI * Rayon * Rayon * Hauteur;
        }
    }
}
