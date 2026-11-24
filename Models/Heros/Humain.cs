using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Heros
{
    internal class Humain : Hero
    {
        public override int Force => ForceBase + 1;
        public override int Endurance => EnduBase + 1;
        public Humain(int x, int y) : base(x, y) { }
    }
}
