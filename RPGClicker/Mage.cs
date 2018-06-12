using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public class Mage : Character
    {
        public override int ClickDamage
        {
            get
            {
                int stat = 2;
                return stat;
            }
        }
        public override int Health
        {
            get
            {
                int stat = 12;
                return stat;
            }
        }
        public override int Armor
        {
            get
            {
                int stat = 1;
                return stat;
            }
        }
        public int Mana { get; set; }

        public Mage(string Name, int Age, bool Admin, int Mana) : base(Name, Age, Admin)
        {
            if (Mana < 0) throw new ArgumentOutOfRangeException("You cannot have negative Mana");

            this.Mana = Mana;
        }
        public int UseSpell(int Mana)
        {
            if (Mana < 0) throw new ArgumentOutOfRangeException("You cannot have negative Mana");
            if (Mana >= 40)
            {
                this.Mana -= 40;
                return ClickDamage * 4;
            }
            return 0;
        }

        public override string ToString()
        {
            string info = base.ToString()
                        + ", " + ClickDamage
                        + ", " + Health
                        + ", " + Armor
                        + ", " + Mana;
            return info;
        }
    }
}