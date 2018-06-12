using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    public class Boss : Enemy
    {
        public decimal Timer { get; private set; }

        public Boss(string Name, int Health, int Damage, decimal Timer) : base(Name, Health, Damage)
        {
            if (Timer <= 0) throw new ArgumentOutOfRangeException("You're not allowed to manipulate time (You're not a wizzard Harry)");
            this.Timer = Timer;
        }

        public int TimeUp(int TotalGold)
        {
            if (TotalGold < 0) throw new ArgumentOutOfRangeException("Cant have negative gold");
            return TotalGold * -1;
        }
        
    }
}
