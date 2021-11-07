using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Parallelepipede : Volume
    {
        double longueur;
        double largeur;
        double profondeur;

        public double Longueur { get => longueur; set => longueur = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Profondeur { get => profondeur; set => profondeur = value; }

        public Parallelepipede(double longueur, double largeur, double profondeur)
        {
            Longueur = longueur;
            Largeur = largeur;
            Profondeur = profondeur;
        }

        public Parallelepipede(double longueur, double largeur, double profondeur, int x, int y, int z)
        {
            Longueur = longueur;
            Largeur = largeur;
            Profondeur = profondeur;
            PositionX = x;
            PositionY = y;
            PositionZ = z;
        }

        public override double getSurface()
        {
            return (Longueur * Largeur) * 2 + (Longueur * Profondeur) * 2 + (Largeur * Profondeur) * 2;
        }

        public override double getVolume()
        {
            return Longueur * Largeur * Profondeur;
        }
    }
}
