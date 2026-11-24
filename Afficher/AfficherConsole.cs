using HeroesVSMonsters.Models;
using HeroesVSMonsters.Models.Heros;
using HeroesVSMonsters.Models.Monstres;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Afficher
{
    internal class AfficherConsole
    {
        public static void AfficherPlateau(Plateau plateau)
        {
            for (int y = 0; y < Plateau.Taille; y++)
            {
                for (int x = 0; x < Plateau.Taille; x++)
                {
                    Monster? monstrePresent = plateau.TrouverMonstre(x, y);
                    if (x == plateau.Hero.X && y == plateau.Hero.Y)
                    {
                        Console.Write(" H ");
                    }
                    else if (monstrePresent is not null && monstrePresent.EstDecouvert)
                    {
                        if (monstrePresent.EstVivant)
                        {
                            Console.Write($" {monstrePresent.LettrePlateau} ");
                        }
                        else
                        {
                            Console.Write(" * ");
                        }

                    }
                    else
                    {
                        Console.Write(" . ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void AfficherDebutCombat(Combat combat, int numero)
        {
            Console.Clear();
            Console.WriteLine($"========== COMBAT {numero} ==========");
            Console.WriteLine();
            Console.WriteLine($"Un {combat.Monstre.GetType().Name} surgit !");
        }
        public static void AfficherTour(Combat combat)
        {
            Console.WriteLine($"========== Tour {combat.Tour} ==========");
            Console.WriteLine();
            Console.WriteLine($"Le {combat.Hero.GetType().Name} frappe : {combat.DegatsHero} dégâts");
            if (!combat.Monstre.EstVivant)
            {
                Console.WriteLine($"Le {combat.Monstre.GetType().Name} est mort");
            }
            if (combat.DegatsMonstre is not null)
            {
                Console.WriteLine($"Le {combat.Monstre.GetType().Name} frappe : {combat.DegatsMonstre} dégâts");
            }
            if (!combat.Hero.EstVivant)
            {
                Console.WriteLine($"Le {combat.Hero.GetType().Name} est mort");
            }
            Console.WriteLine();
        }
        public static void AfficherFinCombat(Combat combat)
        {
            if (combat.HeroGagne)
            {
                Console.WriteLine($"Le {combat.Hero.GetType().Name} a gagné le combat !");
            }
            else
            {
                Console.WriteLine($"Le {combat.Monstre.GetType().Name} a gagné le combat !");
            }
            Console.WriteLine();
        }

        public static void AttendreTouche(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey(true);
        }
        public static void AfficherFinPartie(Hero hero, int tues)
        {
            Console.Clear();

            if (hero.EstVivant)
            {
                Console.WriteLine();
                Console.WriteLine("Le Héros a tué tous les monstres et a nettoyé la forêt.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Malheureusement le Héros est tombé au combat et la forêt reste entre les mains des monstres.");
                Console.WriteLine();
            }

            Console.WriteLine($"Le Héros a tué {tues} monstres.");
            Console.WriteLine();
            Console.WriteLine($"Le Héros a récolté {hero.Or} d'or.");
            Console.WriteLine();
            Console.WriteLine($"Le Héros a aussi récolté {hero.Cuir} cuirs.");

        }
    }
}
