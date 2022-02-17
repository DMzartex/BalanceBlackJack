using System;

namespace Mise
{
    class Program
    {   
        static void mise(int somme, out int balance, out int balanceActu)
        {
            balance = 10000;
            Console.WriteLine("Entrer votre mise et appuyer sur enter.");
            somme = int.Parse(Console.ReadLine());
            balanceActu = balance - somme;
            balance = balanceActu;

            Console.WriteLine(balance);

        }

        static void Main(string[] args)
        {
            int nbrJoueurs;
            Console.WriteLine("Quel est le nombre de joueur ?");
            nbrJoueurs = int.Parse(Console.ReadLine());

            // Création de la matrice

            string[,] cartesJoueur = new string[nbrJoueurs, 10];
        }
    }
}
