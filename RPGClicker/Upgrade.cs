using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public class Upgrade : IBuyable
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string UpgradeType { get; private set; }
        public int TimesBought { get; set; }

        public int price
        {
            get
            {
                int price = 5;
                return price * (10-Value);
            }
        }

        public Upgrade(string Name, string UpgradeType, int Value)
        {
            if (Name == "" || Name == null) throw new ArgumentNullException("Please fill in the correct parameteres");
            if (UpgradeType == "" || UpgradeType == null) throw new ArgumentNullException("Please fill in the correct parameteres");
            if (Value <= 0) throw new ArgumentOutOfRangeException("value cannot be zero or negative");
            this.Name = Name;
            this.UpgradeType = UpgradeType;
            this.Value = Value;
            this.TimesBought = 0;
        }

        public int BuyPrice()
        {
            return price * TimesBought + price;
        }

        public override string ToString()
        {
            string info = Name
                        + ": +" + Value
                        + " " + UpgradeType
                        + " " + BuyPrice() + "G";
            return info;
        }
    }
}