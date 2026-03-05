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
            MethodesProjet.LireEntier("Nombre de ligne dans votre matrice : ", out nombreLigne);
            MethodesProjet.LireEntier("Nombre de colonne dans votre matrice : ", out nombreColonne);
            MethodesProjet.LireEntier("Borne minimum pour les valeurs de votre matrice : ", out borneMin);
            MethodesProjet.LireEntier("Borne maximum pour les valeurs de votre matrice : ", out borneMax);

            MethodesProjet.RemplirMatrice(nombreLigne, nombreColonne, borneMin, borneMax, out matrice);

            MethodesProjet.LireMatrice(matrice, out contenu);

            Console.WriteLine(contenu);

            Console.WriteLine("Entrez espace pour recommencer.");
            recommencer = Console.ReadLine();
        }
        while (recommencer == " ");
    }
}
