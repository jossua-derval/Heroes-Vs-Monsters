using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Monstres
{
    internal abstract class Monster : Personnage
    {
        public abstract char LettrePlateau { get; }
        public bool EstDecouvert { get; private set; } = false;
        protected Monster(int x, int y) : base(x, y) { }

        public static Monster CreeMonstrer(int cas, int x, int y)
        {
            switch (cas)
            {
                case 1: return new Orque(x, y);
                case 2: return new Loup(x, y);
                default: return new Dragonnet(x, y);
            }
        }
        public void Decouvrir()
        {
            this.EstDecouvert = true;
        }
    }
}
