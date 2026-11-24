using HeroesVSMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models.Monstres
{
    internal class Loup : Monster, ICuir
    {
        public override char LettrePlateau => 'L';
        public int QuantiteCuir { get; } = _d4.Lance();
        public Loup(int x, int y) : base(x, y) { }
    }
}
