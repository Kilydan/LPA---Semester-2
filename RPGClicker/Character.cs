using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    [Serializable()]
    public abstract class Character
    {
        private List<Upgrade> upgrades = new List<Upgrade>();
        private List<Item> items;
        public List<Item> Items
        {
            get
            {
                if(this.items == null)
                {
                    this.items = new List<Item>();
                }
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }
        private List<Item> equipedItems;
        public List<Item> EquipedItems
        {
            get
            {
                if (this.equipedItems == null)
                {
                    this.equipedItems = new List<Item>();
                }
                return this.equipedItems;
            }
            set
            {
                this.equipedItems = value;
            }
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public abstract int ClickDamage { get; }
        public abstract int Health { get; }
        public abstract int Armor { get; }
        public bool Admin { get; private set; }

        public int Gold
        {
            get
            {
                return 0;
            }
        }

        public Character(string Name, int Age, bool Admin)
        {
            if (Name == "" || Name == null) throw new ArgumentNullException("Character name cannot be empty");
            if (Age <= 0) throw new ArgumentOutOfRangeException("Age cannot be zero");
            this.Name = Name;
            this.Age = Age;
            this.Admin = Admin;
        }
        public bool AddItem(Item item)
        {
            if (item == null) throw new ArgumentNullException("Please select an item to add");

            EquipedItems.Add(item);
            return true;
        }
        public bool RemoveItem(Item item)
        {
            if (item == null) throw new ArgumentNullException("Please select an item to remove");

            EquipedItems.Remove(item);
            return true;
        }

        public bool Upgrade(Upgrade Upgrade)
        {
            if (Upgrade == null) throw new ArgumentNullException("please select an upgrade");
            upgrades.Add(Upgrade);
            return true;
        }
        public int Attack()
        {
            //attack multipliers
            return ClickDamage + GetUpgradeValue("ClickDamage");
        }
        public int Heal()
        {
            //heal multipliers
            return (Health + GetUpgradeValue("Health")) / 10;
        }
        public int GetUpgradeValue(string type)
        {
            if (type == null || type == "") throw new ArgumentNullException("upgrade type is empty");
            int bonusValue = 0;
            if (upgrades == null || items == null)
            {
                return 0;
            }
            else
            {
                foreach (Upgrade upgrade in upgrades)
                {
                    if (upgrade.UpgradeType == type)
                    {
                        bonusValue += upgrade.Value;
                    }
                }
                foreach (Item item in EquipedItems)
                {
                    if (item.ItemType == type)
                    {
                        bonusValue += item.Value;
                    }
                }
            }
            return bonusValue;
        }

        public override string ToString()
        {
            string info = Name
                        + ", " + Age
                        + ", " + Gold;
            return info;
        }
    }
}
