using HeroesVSMonsters.Afficher;
using HeroesVSMonsters.Models;
using HeroesVSMonsters.Models.Monstres;

Plateau plateau = new Plateau();
AfficherConsole _ = new AfficherConsole();
int monstresTues = 0;
int combat = 1;

while (plateau.Hero.EstVivant && plateau.MonstresVivants > 0)
{
    Console.Clear();
    AfficherConsole.AfficherPlateau(plateau);
    ConsoleKeyInfo touche = Console.ReadKey(true);
    ConsoleKey touchePressee = touche.Key;
    switch (touchePressee)
    {
        case ConsoleKey.RightArrow: plateau.Hero.SeDeplacer(1, 0); break;
        case ConsoleKey.LeftArrow: plateau.Hero.SeDeplacer(-1, 0); break;
        case ConsoleKey.UpArrow: plateau.Hero.SeDeplacer(0, -1); break;
        case ConsoleKey.DownArrow: plateau.Hero.SeDeplacer(0, 1); break;
    }
    Monster? monsterVoisin = plateau.DecouvrirMonstreVoisin();
    if (monsterVoisin is not null)
    {
        Combat combatEnCours = new Combat(plateau.Hero, monsterVoisin);
        AfficherConsole.AfficherDebutCombat(combatEnCours, combat);
        while (!combatEnCours.EstTermine)
        {
            combatEnCours.JouerTour();
            AfficherConsole.AfficherTour(combatEnCours);
            if (!combatEnCours.EstTermine)
            {
                AfficherConsole.AttendreTouche("Appuyer sur une touche pour passer au tour suivant...");
                Console.Clear();
            }
            
        }
        AfficherConsole.AfficherFinCombat(combatEnCours);
        if (combatEnCours.HeroGagne)
        {
            monstresTues++;
        }
        combat++;
        AfficherConsole.AttendreTouche("Appuyer sur une touche pour revenir au plateau...");
    }
}

AfficherConsole.AfficherFinPartie(plateau.Hero, monstresTues);