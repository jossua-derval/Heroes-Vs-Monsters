using HeroesVSMonsters.Models.Heros;
using HeroesVSMonsters.Models.Monstres;

namespace HeroesVSMonsters.Models
{
    internal class Plateau
    {
        private readonly De _d15 = new De(0, Taille - 1);
        public const int Taille = 15;
        public Hero Hero { get; private set; }
        private readonly List<Monster> _monsters = new List<Monster>();
        public Plateau()
        {
            PlacerMonstre();
            Hero = PlacerHero();
        }
        private bool EstTropProche(int x, int y)
        {
            foreach (var monster in _monsters)
            {
                int ecartHorizontal = Math.Abs(monster.X - x);
                int ecartVertical = Math.Abs(monster.Y - y);
                if (ecartHorizontal < 3 && ecartVertical < 3)
                {
                    return true;
                }
            }
            return false;
        }
        private void PlacerMonstre()
        {
            for (int i = 0; i < 10; i++)
            {
                int x;
                int y;
                do
                {
                    x = _d15.Lance();
                    y = _d15.Lance();
                }
                while (EstTropProche(x, y));
                Monster monstre = Monster.CreeMonstrer(Random.Shared.Next(1, 4), x, y);
                _monsters.Add(monstre);
            }
        }
        private Hero PlacerHero()
        {
            int x;
            int y;
            do
            {
                x = _d15.Lance();
                y = _d15.Lance();
            }
            while (EstTropProche(x, y));
            Hero hero = Hero.CreerHero(Random.Shared.Next(1, 3), x, y);
            return hero;
        }
        internal Monster? TrouverMonstre(int x, int y)
        {
            foreach (var monster in _monsters)
            {
                if (monster.X == x && monster.Y == y)
                {
                    return monster;
                }
            }
            return null;
        }
        public Monster? DecouvrirMonstreVoisin()
        {
            foreach (var monstre in _monsters)
            {
                int ecartHorizontal = Math.Abs(monstre.X - Hero.X);
                int ecartVertical = Math.Abs(monstre.Y - Hero.Y);
                if (monstre.EstVivant && ecartVertical + ecartHorizontal == 1)
                {
                    monstre.Decouvrir();
                    return monstre;
                }
            }
            return null;
        }
        public int MonstresVivants => _monsters.Count((m) => m.EstVivant);
    }
}
