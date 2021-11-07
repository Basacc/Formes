using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    abstract class Forme : IForme
    {
        int positionX;
        int positionY;
        Couleurs couleur;

        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        public Couleurs Couleur { get => couleur; set => couleur = value; }

        public void deplacer(int x, int y)
        {
            PositionX += x;
            PositionY += y;
        }
        public void setPosition(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
        public int[] getPosition()
        {
            return new int[] { PositionX, PositionY};
        }

        public Couleurs getCouleur()
        {
            return this.Couleur;
        }
        public void setCouleur(Couleurs c)
        {
            this.Couleur = c;
        }

        public abstract double getPerimetre();

        public abstract double getSurface();
        


    }
}
