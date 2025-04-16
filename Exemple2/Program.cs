namespace Exemple2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("+++ Résolution d'une équation de second degré +++");
                Console.WriteLine("Entrez le coefficient A: ");
                double A = double.Parse(Console.ReadLine());

                Console.WriteLine("Entrez le coefficient B: ");
                double B = double.Parse(Console.ReadLine());

                Console.WriteLine("Entrez le coefficient C: ");
                double C = double.Parse(Console.ReadLine());

                EquationSecondDegre equation = new EquationSecondDegre(A, B, C);
                equation.Resoudre();

            }
            catch (ExceptionEquation ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Erreur: Format invalide");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erreur inattendue: " + ex.Message);
                //Utilisé en dernier recours pour capter toutes les erreurs non spécifiquement gérées
            }
        }
    }
}
