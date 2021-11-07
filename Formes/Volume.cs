using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    abstract class Volume : IVolume
    {
        int positionX;
        int positionY;
        int positionZ;
        Couleurs couleur;

        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        public Couleurs Couleur { get => couleur; set => couleur = value; }
        public int PositionZ { get => positionZ; set => positionZ = value; }

        public void deplacer(int x, int y, int z)
        {
            PositionX += x;
            PositionY += y;
            PositionZ += z;
        }

        public Couleurs getCouleur()
        {
            return Couleur;
        }

        public int[] getPosition()
        {
            return new int[] { PositionX, PositionY, PositionZ };
        }

        public abstract double getSurface();


        public abstract double getVolume();
        

        public void setCouleur(Couleurs c)
        {
            Couleur = c;
        }

        public void setPosition(int x, int y, int z)
        {
            PositionX = x;
            PositionY = y;
            PositionZ = z;
        }
    }
}
