using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public class Item : ISellable
    {
        public string Rarity { get; private set; }
        public string Name { get; private set; }
        public string ItemType { get; private set; }
        public int Value { get; private set; }

        public int price
        {
            get
            {
                Random r = new Random();
                int price = r.Next(Value * 3, Value * 5);

                if (Rarity == "Epic")
                {
                    price = price * 2;
                }
                return price;
            }
        }

        public Item(string Rarity, string Name, string ItemType, int Value)
        {
            if (Name == "" || Name == null) throw new ArgumentNullException("Please fill in the correct parameteres");
            if (Rarity == "" || Rarity == null) throw new ArgumentNullException("Please make sure you've chosen a valid rarity");
            if (ItemType == "" || ItemType == null) throw new ArgumentNullException("Please make sure you've chosen a valid ItemType");
            if (Value <= 0) throw new ArgumentOutOfRangeException("value cannot be zero or negative");
            this.Rarity = Rarity;
            this.Name = Name;
            this.ItemType = ItemType;
            this.Value = Value;
        }

        public int SellItem()
        {
            return price;
        }
        public override string ToString()
        {
            string info = Rarity
                        + ": " + Name
                        + "  +" + Value
                        + " " + ItemType;
            return info;
        }
    }
}
