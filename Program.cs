namespace _5TTI_MaelDayaniPoty_Matrice;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] matrice; //déclarer matrice
        int nombreLigne;
        int nombreColonne;
        int borneMin;
        int borneMax;
        string contenu;
        string recommencer;

        do
        {
            nombreLigne = MethodesProjet.LireEntier("Nombre de ligne dans votre matrice : ");
            nombreColonne = MethodesProjet.LireEntier("Nombre de colonne dans votre matrice : ");
            borneMin = MethodesProjet.LireEntier("Borne minimum pour les valeurs de votre matrice : ");
            borneMax = MethodesProjet.LireEntier("Borne maximum pour les valeurs de votre matrice : ");

            matrice = MethodesProjet.RemplirMatrice(nombreLigne, nombreColonne, borneMin, borneMax);

            contenu = MethodesProjet.LireMatrice(matrice);

            Console.WriteLine(contenu);

            Console.WriteLine("Entrez espace pour recommencer.");
            recommencer = Console.ReadLine();
        }
        while (recommencer == " ");
    }
}
