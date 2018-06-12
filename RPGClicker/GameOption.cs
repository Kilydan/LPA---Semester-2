using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace RPGClicker
{
    public class GameOption
    {
        public List<Upgrade> Upgrades { get; private set; }
        public List<Enemy> Enemies { get; private set; }

        public GameOption()
        {
            Upgrades = new List<Upgrade>();
            Enemies = new List<Enemy>();

            Enemy enemy = new Enemy("Derpmander", 10, 1);
            Upgrade upgHealth = new Upgrade("Better Chestplate", "Health", 5);
            Upgrade upgArmor = new Upgrade("Better Helmet", "Armor", 2);
            Upgrade upgDamage = new Upgrade("Better Sword", "ClickDamage", 3);
            addUpgrade(upgHealth);
            addUpgrade(upgArmor);
            addUpgrade(upgDamage);
            addEnemy(enemy);
        }

        public bool addUpgrade(Upgrade upgrade)
        {
            if (upgrade == null) throw new ArgumentNullException("Upgrade cannot be empty");

            Upgrades.Add(upgrade);
            return true;
        }
        public bool addEnemy(Enemy enemy)
        {
            if (enemy == null) throw new ArgumentNullException("Enemy cannot be empty");

            Enemies.Add(enemy);
            return true;
        }
        public Character createCharacter(string characterClass, string name, int age, bool admin)
        {
            if (characterClass == "" || characterClass == null) throw new ArgumentNullException("Character cannot be empty");
            if (name == "" || name == null) throw new ArgumentNullException("Character name cannot be empty");
            if (age <= 0) throw new ArgumentNullException("Age cannot be zero");
            switch (characterClass)
            {
                case "Warrior":
                    Warrior warrior = new Warrior(name, age, admin, 0);
                    return warrior;
                case "Mage":
                    Mage mage = new Mage(name, age, admin, 200);
                    return mage;
                case "Summoner":
                    Summoner summoner = new Summoner(name, age, admin);
                    return summoner;
            }
            return null;
        }
        public Enemy summonEnemy()
        {
            Random r = new Random();
            int num = r.Next(0, Enemies.Count);
            return Enemies[num];
        }

        public bool Save(string fileName, Character character)
        {
            if (fileName == null || fileName == "") throw new System.ArgumentNullException("fileName");
            if (character == null) throw new System.ArgumentNullException("no character");
            if (!File.Exists(fileName)) throw new FileNotFoundException("file not found");
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FormatException();
                }
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, character);
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public Character Load(string fileName, Character character)
        {
            if (fileName == null || fileName == "") throw new System.ArgumentNullException("fileName");
            if (!File.Exists(fileName)) throw new FileNotFoundException("file not found");
                Stream stream = File.Open(fileName, FileMode.Open);
            using (stream)
            {
                BinaryFormatter bin = new BinaryFormatter();

                character = null;

                character = (Character)bin.Deserialize(stream);
                return character;

            }
        }
    }
}
