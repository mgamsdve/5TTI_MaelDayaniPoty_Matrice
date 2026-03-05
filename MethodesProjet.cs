namespace _5TTI_MaelDayaniPoty_Matrice;

public class MethodesProjet
{
    public static void LireEntier(string question, out int resultat)
    {
        do
        {
            Console.WriteLine(question);
        }
        while (!int.TryParse(Console.ReadLine(), out resultat));
    }

    public static void LireMatrice(int[,] matrice, out string contenu)
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


    public static void RemplirMatrice(int nombreLigne, int nombreColonne, int borneMin, int borneMax, out int[,] matrice)
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