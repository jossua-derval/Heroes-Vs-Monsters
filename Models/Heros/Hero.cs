using System;
using System.Collections.Generic;
using System.Text;
using HeroesVSMonsters.Interfaces;
using HeroesVSMonsters.Models.Monstres;

namespace HeroesVSMonsters.Models.Heros
{
    internal abstract class Hero : Personnage
    {
        public int Or {  get; private set; }
        public int Cuir { get; private set; }
        protected Hero(int x, int y) :base(x, y) { }
        public static Hero CreerHero(int cas, int x, int y)
        {
            switch (cas)
            {
                case 1: return new Humain(x, y);
                default: return new Nain(x, y);
            }
        }
        public void SeReposer()
        {
            RestaurerPv();
        }
        public void RecupButin(Monster monster)
        {
            if (monster.EstVivant)
            {
                return;
            }
            if (monster is IOr gold)
            {
                Or += gold.QuantiteOr;
            }
            if (monster is ICuir cuir)
            {
                Cuir += cuir.QuantiteCuir;
            }
        }
        public void SeDeplacer(int decalX, int decalY)
        {

            if (this.X + decalX > Plateau.Taille - 1 || this.Y + decalY > Plateau.Taille - 1 || this.X + decalX < 0 || this.Y + decalY < 0)
            {
                return;
            }
            this.X += decalX;
            this.Y += decalY;
        }
    }
}
