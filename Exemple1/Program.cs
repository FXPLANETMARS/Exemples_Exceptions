namespace Exemple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemple 1

            /*try
            {
                int a = 100;
                int b = 0;
                int resultat = a / b; //Division par zéro
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erreur : Division par zéro");
                Console.WriteLine(ex.Message);
            }*/

            //Deuxième cas

            /*try
            {
                Console.WriteLine("Entrer un nombre: ");
                int nombre = int.Parse(Console.ReadLine());
                Console.WriteLine("Vous avez saisi: " + nombre);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur: ce n'est pas un nombre");
            }*/

            //Troisième cas

            StreamReader fichier = null;
            try
            {
                fichier = new StreamReader("donnees.csv");
                string contenu = fichier.ReadToEnd();//Lecture jusqu'à la fin du fichier
                Console.WriteLine(contenu);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fichier non trouvé...");

            }
            finally
            {
                if (fichier != null)
                {
                    fichier.Close();
                }

            }
        
        
        
        
        }
    }
}
