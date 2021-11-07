using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    public interface IForme
    {
        // Permet de déplacer la forme par rapport à sa position
        void deplacer(int x, int y);
        // Permet de définir une nouvelle position de la forme
        void setPosition(int x, int y);
        // Retourne la position de la forme
        int[] getPosition();
        // Retourne l'aire (superficie) de la forme
        double getSurface();
        // Retourne le périmètre de la forme
        double getPerimetre();
        // Change la couleur de la forme
        void setCouleur(Couleurs c);
        // Retourne la couleur de la forme
        Couleurs getCouleur();
    }
}
