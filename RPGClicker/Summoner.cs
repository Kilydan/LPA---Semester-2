using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public class Summoner : Character
    {

        public int Dps { get; private set; }
        public decimal Cooldown { get; set; }

        public override int ClickDamage
        {
            get
            {
                int stat = 1;
                return stat;
            }
        }
        public override int Health
        {
            get
            {
                int stat = 15;
                return stat;
            }
        }
        public override int Armor
        {
            get
            {
                int stat = 2;
                return stat;
            }
        }

        public Summoner(string Name, int Age, bool Admin) : base(Name, Age, Admin)
        {
            Random r = new Random();
            this.Dps = r.Next(1,4);
            this.Cooldown = 0;
        }

        public bool SummonMinion(decimal Cooldown, int clickDamage)
        {
            if (Cooldown < 0) throw new ArgumentOutOfRangeException("You cannot have negative cooldown");
            if (clickDamage <= 0) throw new ArgumentOutOfRangeException("You cannot have zero or negative clickdamage");
            if (Cooldown == 0)
            {
                Dps += clickDamage;
                this.Cooldown = 30;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string info = base.ToString()
                        + ", " + ClickDamage
                        + ", " + Dps
                        + ", " + Health
                        + ", " + Armor
                        + ", " + Cooldown;
            return info;
        }
    }
}
