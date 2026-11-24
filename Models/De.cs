using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models
{
    internal class De
    {
        public int Minimum { get; }
        public int Maximum { get; }
        public De(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
        public int Lance()
        {
            return Random.Shared.Next(Minimum, Maximum + 1);
        }
    }
}
