using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple2
{
    internal class EquationSecondDegre
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public EquationSecondDegre(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        //Résolution de l'équation
        public void Resoudre()
        {
            if (A == 0)
            {
                Console.WriteLine("Ce n'est pas une équation du second degré (A ne doit pas être 0)");
                return;
            }
            double discriminant = B * B - 4 * A * C;

            Console.WriteLine("Discriminant: " + discriminant);

            if (discriminant < 0)
            {
                throw new ExceptionEquation();//Lance une exception de type ExceptionEquation (notre type de classe) (Celle qu'on a créé nous mêmes)
            }
            else if (discriminant == 0)
            {
                double x = -B / (2 * A);
                Console.WriteLine($"Une solution réelle : X={x}");
            }
            else
            {
                double racineDiscriminant = Math.Sqrt(discriminant);
                double x1 = (-B - racineDiscriminant) / 2 * A;
                double x2 = (-B + racineDiscriminant) / 2 * A;
                Console.WriteLine($"Deux solutions réelles: x1={x1} et x2={x2}");
            }
        }
    }
}
