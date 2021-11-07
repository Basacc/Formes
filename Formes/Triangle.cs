using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    class Triangle : Forme
    {
        double cote1;
        double cote2;
        double cote3;
        double hauteur;
        double baseTriangle;

        public double Cote1 { get => cote1; set => cote1 = value; }
        public double Cote2 { get => cote2; set => cote2 = value; }
        public double Cote3 { get => cote3; set => cote3 = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }
        public double BaseTriangle { get => baseTriangle; set => baseTriangle = value; }

        public Triangle(double cote1, double cote2, double cote3, double hauteur, double baseTriangle)
        {
            Cote1 = cote1;
            Cote2 = cote2;
            Cote3 = cote3;
            Hauteur = hauteur;
            BaseTriangle = baseTriangle;
        }

        public Triangle(double cote1, double cote2, double cote3, double hauteur, double baseTriangle, int x, int y)
        {
            Cote1 = cote1;
            Cote2 = cote2;
            Cote3 = cote3;
            Hauteur = hauteur;
            BaseTriangle = baseTriangle;
            PositionX = x;
            PositionY = y;
        }

        public override double getPerimetre()
        {
            return Cote1 + Cote2 + Cote3;
        }

        public override double getSurface()
        {
            return (BaseTriangle * Hauteur) / 2;
        }
    }
}
