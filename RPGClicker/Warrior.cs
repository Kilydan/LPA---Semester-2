using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public class Warrior : Character
    {
        public override int ClickDamage
        {
            get
            {
                int stat = 5;
                return stat;
            }
        }
        public override int Health
        {
            get
            {
                int stat = 20;
                return stat;
            }
        }
        public override int Armor
        {
            get
            {
                int stat = 5;
                return stat;
            }
        }
        public int Rage { get; set; }

        public Warrior(string Name, int Age, bool Admin, int Rage) : base(Name, Age, Admin)
        {
            if (Rage < 0) throw new ArgumentOutOfRangeException("Rage cannot be lower then 0");
            this.Rage = Rage;
        }
        public int UseRage(int Rage)
        {
            if (Rage < 0) throw new ArgumentOutOfRangeException("Rage cannot be lower then 0");

            int dmg = Rage;
            this.Rage = 0;
            return dmg;
        }

        public override string ToString()
        {
            string info = base.ToString()
                        + ", " + ClickDamage
                        + ", " + Health
                        + ", " + Armor
                        + ", " + Rage;
            return info;
        }
    }
}
