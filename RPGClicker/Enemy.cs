using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    public class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int GoldDrop
        {
            get
            {
                int GoldAmount = Health/10 + Damage/2;
                return GoldAmount;
            }
        }
        public int ItemDropChance
        {
            get
            {
                // 0 - 100 in %
                int DropChance = 2;
                return DropChance;
            }
        }
        public Enemy(string Name, int Health, int Damage)
        {
            if (Name == "" || Name == null) throw new ArgumentNullException("Character name cannot be empty");
            if (Health <= 0) throw new ArgumentOutOfRangeException("Health cannot be zero or less");
            if (Damage <= 0) throw new ArgumentOutOfRangeException("Damage cannot be lower than 0");

            this.Name = Name;
            this.Health = Health;
            this.Damage = Damage;
        }

        public bool OnDeathEvent(decimal ItemDropChance)
        {
            Random r = new Random();
            int drop = r.Next(1, 101);
            if (drop <= ItemDropChance)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string info = Name + " dropped " + GoldDrop + " g";
            return info;
        }
    }
}
