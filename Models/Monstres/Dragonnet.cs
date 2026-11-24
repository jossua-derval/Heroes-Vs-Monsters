using HeroesVSMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Monstres
{
    internal class Dragonnet : Monster, IOr, ICuir
    {
        public override char LettrePlateau => 'D';
        public override int Endurance => EnduBase + 1;
        public int QuantiteOr { get; } = _d6.Lance();
        public int QuantiteCuir { get; } = _d4.Lance();
        public Dragonnet(int x, int y) :base(x, y) { }
    }
}
