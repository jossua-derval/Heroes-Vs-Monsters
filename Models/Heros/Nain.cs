using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Heros
{
    internal class Nain : Hero
    {
        public override int Endurance => EnduBase + 2;
        public Nain(int x, int y) : base(x, y) { }
    }
}
