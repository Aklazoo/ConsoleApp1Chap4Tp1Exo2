using System;

namespace ConsoleApp1Chap4Tp1Exo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Quel est le niveau de votre personnage ? \nVeuillez choisir votre niveau exact ! ");
            int niveau = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quelle est votre classe principale ? \n G pour Guerrier \n M pour mage \n R pour Rogue ");
            string classe = Console.ReadLine();

            Console.WriteLine($" Quelle est votre nombre de quêtes héroiques accomplies ? ");
            int quetes = int.Parse(Console.ReadLine());

           
            string titre = "Statut Indéterminé / Hors-la-loi";

            // 1. Tranche de niveau inférieure à 10
            if (niveau < 10)
            {
                titre = "Novice";
            }
            // 2. Tranche de niveau entre 10 et 19
            else if (niveau >= 10 && niveau < 20)
            {
                if (quetes >= 5)
                {
                    titre = "Adepte";
                }
                else
                {
                    titre = "Apprenti assermenté";
                }
            }
            // 3. Tranche de niveau entre 20 et 30 (Gestion du Vétéran)
            else if (niveau >= 20 && niveau <= 30)
            {
                if (classe == "G" && niveau >= 25)
                {
                    titre = "Vétéran";
                }
                else
                {
                    titre = "Vétéran";
                }
            }
            // 4. Tranche de niveau supérieure à 30
            else if (niveau > 30 && quetes > 20)
            {
                
                if (classe == "G" || classe == "M")
                {
                    titre = "Maitre de guilde";
                }
                else if (classe == "R")
                {
                    Console.WriteLine($"Revenez lorsque vous aurez votre certificat d'examen spécial !");
                    return;
                }
            }

            
            Console.WriteLine($"Votre titre est : {titre}");
        }
    }
}
