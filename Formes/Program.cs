using System;

namespace Formes
{
    public enum Couleurs
    {
        BLEU, ROUGE, VERT, JAUNE, NOIR, BlANC
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Carre carre = new Carre(2);
            Carre carre1 = new Carre(2, 0, 0);
            Rectangle rectangle = new Rectangle(2, 5);
            Rectangle rectangle1 = new Rectangle(3, 7, 0, 0);
            Triangle triangle = new Triangle(3, 4, 5, 4, 3);
            Triangle triangle1 = new Triangle(3, 4, 5, 4, 3, 1, 2);
            Cercle cercle = new Cercle(5);
            Cercle cercle1 = new Cercle(7, 2, 4);
            Cube cube = new Cube(4);
            Cube cube1 = new Cube(2, 0, 0, 0);
            Parallelepipede parallelepipede = new Parallelepipede(4, 2, 8);
            Parallelepipede parallelepipede1 = new Parallelepipede(2, 7, 4, 0, 0, 0);
            Sphere sphere = new Sphere(7);
            Sphere sphere1 = new Sphere(4, 4, 0, 2);
            Cylindre cylindre = new Cylindre(2,5);
            Cylindre cylindre1 = new Cylindre(4, 8, 0, 0, 0);

            carre.setCouleur(Couleurs.BlANC);
            carre1.setPosition(1, 1);
            Console.WriteLine("Le carré est " + carre.getCouleur().ToString());
            Console.WriteLine("Le carré se trouve à la position " + carre1.getPosition()[0].ToString() + ","+ carre1.getPosition()[1]);
            Console.WriteLine("Le périmetre du rectangle est " + rectangle.getPerimetre().ToString());
            Console.WriteLine("L'aire du cercle est " + cercle.getSurface().ToString());
            Console.WriteLine("La surface du cube est " + cube.getSurface().ToString());
            Console.WriteLine("Le volume du cylindre est " + cylindre1.getVolume().ToString());
            Console.ReadLine();

        }
    }
}
