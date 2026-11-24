using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVSMonsters.Models
{
    public abstract class Personnage
    {
        private protected static readonly De _d6 = new De(1, 6);
        private protected static readonly De _d4 = new De(1, 4);
        public int EnduBase { get; }
        public int ForceBase { get; }
        public virtual int Force => ForceBase;
        public virtual int Endurance => EnduBase;
        private int _pv;
        private readonly int _pvMax;
        public bool EstVivant => _pv > 0;
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public event Action<Personnage>? MeurtEvent;
        
        protected Personnage(int x, int y)
        {
            X = x;
            Y = y;
            EnduBase = LancerCaracteristique();
            ForceBase = LancerCaracteristique();
            _pvMax = Endurance + Modificateur(Endurance);
            _pv = _pvMax;
        }
        private static int LancerCaracteristique()
        {
            List<int> des = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                des.Add(_d6.Lance());
            }

            des.Remove(des.Min());
            return des.Sum();
        }
        protected void RestaurerPv()
        {
            _pv = _pvMax;
        }
        private void SubirDegat(int degats)
        {
            if (!EstVivant)
            {
                return;
            }
            _pv -= degats;
            _pv = Math.Max(0, _pv);
            if (_pv <= 0)
            {
                MeurtEvent?.Invoke(this);
            }
        }
        public int Frapper(Personnage cible)
        {
            int degat = _d4.Lance() + Modificateur(Force);
            cible.SubirDegat(degat);
            return degat;
        }
        private static int Modificateur(int caracteristique)
        {
            if (caracteristique < 5)
            {
                return -1;
            }
            else if (caracteristique < 10)
            {
                return 0;
            }
            else if (caracteristique < 15)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
