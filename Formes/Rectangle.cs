using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Rectangle : Forme
    {
        double longueur;
        double largeur;

        public double Longueur { get => longueur; set => longueur = value; }
        public double Largeur { get => largeur; set => largeur = value; }

        public Rectangle(double longeur, double largeur)
        {
            this.Longueur = longeur;
            this.Largeur = largeur;
        }

        public Rectangle(double longeur, double largeur, int x, int y)
        {
            this.Longueur = longeur;
            this.Largeur = largeur;
            this.PositionX = x;
            this.PositionY = y;
        }

        public override double getPerimetre()
        {
            return (Longueur * 2) + (Largeur * 2);
        }

        public override double getSurface()
        {
            return Longueur * Largeur;
        }
    }
}
