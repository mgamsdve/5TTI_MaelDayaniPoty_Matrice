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
            LireEntier("Nombre de ligne dans votre matrice : ", out nombreLigne);
            LireEntier("Nombre de colonne dans votre matrice : ", out nombreColonne);
            LireEntier("Borne minimum pour les valeurs de votre matrice : ", out borneMin);
            LireEntier("Borne maximum pour les valeurs de votre matrice : ", out borneMax);

            RemplirMatrice(nombreLigne, nombreColonne, borneMin, borneMax, out matrice);

            LireMatrice(matrice, out contenu);

            Console.WriteLine(contenu);

            Console.WriteLine("Entrez espace pour recommencer.");
            recommencer = Console.ReadLine();
        }
        while (recommencer == " ");
    }

    static void LireEntier(string question, out int resultat)
    {
        do
        {
            Console.WriteLine(question);
        }
        while (!int.TryParse(Console.ReadLine(), out resultat));
    }

    static void LireMatrice(int[,] matrice, out string contenu)
    {
        contenu = "";
        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                contenu += matrice[iLigne, iColonne] + "; ";
            }

            contenu += "\n";
        }
    }


    static void RemplirMatrice(int nombreLigne, int nombreColonne, int borneMin, int borneMax, out int[,] matrice)
    {
        Random alea = new Random();
        matrice = new int[nombreLigne, nombreColonne];
        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                matrice[iLigne, iColonne] = alea.Next(borneMin, borneMax + 1);
            }
        }
    }
}
