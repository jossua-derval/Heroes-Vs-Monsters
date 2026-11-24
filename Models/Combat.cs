using HeroesVSMonsters.Models.Heros;
using HeroesVSMonsters.Models.Monstres;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models
{
    internal class Combat
    {
        public Hero Hero { get; }
        public Monster Monstre { get; }
        public int Tour { get; private set; }
        public int DegatsHero { get; private set; }
        public int? DegatsMonstre { get; private set; }
        public bool EstTermine => !Hero.EstVivant || !Monstre.EstVivant;
        public bool HeroGagne => Hero.EstVivant && !Monstre.EstVivant;

        internal Combat(Hero hero, Monster monstre)
        {
            Hero = hero;
            Monstre = monstre;
            Tour = 0;
        }

        public void JouerTour()
        {
            Tour++;
            DegatsMonstre = null;

            DegatsHero = Hero.Frapper(Monstre);

            if (Monstre.EstVivant)
            {
                DegatsMonstre = Monstre.Frapper(Hero);
            }

            if (HeroGagne)
            {
                Hero.RecupButin(Monstre);
                Hero.SeReposer();
            }
        }
    }
}