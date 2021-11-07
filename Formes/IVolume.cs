using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    interface IVolume
    {
        // Permet de déplacer le volume par rapport à sa position
        void deplacer(int x, int y, int z);
        // Permet de définir une nouvelle position du volume
        void setPosition(int x, int y, int z);
        // Retourne la position du volume
        int[] getPosition();
        // Retourne l'aire (superficie) du volume
        double getSurface();
        // Retourne le volume du volume
        double getVolume();
        // Change la couleur du volume
        void setCouleur(Couleurs c);
        // Retourne la couleur du volume
        Couleurs getCouleur();
    }
}
