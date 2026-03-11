namespace _5TTI_MaelDayaniPoty_Matrice;

public class MethodesProjet
{
    public static int LireEntier(string question)
    {
        int resultat;
        do
        {
            Console.WriteLine(question);
        }
        while (!int.TryParse(Console.ReadLine(), out resultat));
        return resultat;
    }

    public static string LireMatrice(int[,] matrice)
    {
        string contenu = "";
        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                contenu += matrice[iLigne, iColonne] + "; ";
            }
            
            contenu += "\n";
        }
        return contenu;
    }

    public static int[,] RemplirMatrice(int nombreLigne, int nombreColonne, int borneMin, int borneMax)
    {
        Random alea = new Random();
        int[,] matrice = new int[nombreLigne, nombreColonne];
        for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                matrice[iLigne, iColonne] = alea.Next(borneMin, borneMax + 1);
            }
        }
        return matrice;
    }
}