using HeroesVSMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Monstres
{
    internal class Orque : Monster, IOr
    {
        public override char LettrePlateau => 'O';
        public override int Force => ForceBase + 1;
        public int QuantiteOr { get; } = _d6.Lance();
        public Orque(int x, int y) : base(x, y) { }
    }
}
