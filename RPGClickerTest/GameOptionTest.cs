using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;
using System.IO;

namespace RPGClickerTest
{
    [TestClass]
    public class GameOptionTest
    {
        [TestMethod]
        public void TestGameOptionsIfUpgradeCanBeAddedToList()
        {
            GameOption GameOption = new GameOption();
            Upgrade upg = new Upgrade("random", "ClickDamage", 30);
            GameOption.Upgrades.Clear();
            GameOption.addUpgrade(upg);
            Upgrade upg1 = GameOption.Upgrades[0];
            Assert.AreEqual(upg1, upg);
        }
        [TestMethod]
        public void TestGameOptionsIfEnemyCanBeAddedToList()
        {
            GameOption GameOption = new GameOption();
            Enemy enemy = new Enemy("Slime", 5, 1);
            GameOption.Enemies.Clear();
            GameOption.addEnemy(enemy);
            Enemy enemy1 = GameOption.Enemies[0];
            Assert.AreEqual(enemy1, enemy);
        }
        [TestMethod]
        public void TestGameOptionsIfCharacterCanBeMade()
        {
            GameOption GameOption = new GameOption();
            Warrior warrior = (Warrior)GameOption.createCharacter("Warrior", "Linus", 7, false);
            Assert.AreEqual("Linus", warrior.Name);
            Assert.AreEqual(7, warrior.Age);
            Assert.AreEqual(false, warrior.Admin);
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsAddUpgradeCanFail()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.addUpgrade(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsAddEnemyCanFail()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.addEnemy(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsCreateCharacterWithoutName()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.createCharacter("Warrior", "", 7, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsCreateCharacterWithoutClass()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.createCharacter("", "Linus", 7, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsCreateCharacterWithNegativeAge()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.createCharacter("Warrior", "Linus", -4, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsCreateCharacterWithZeroAsAge()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.createCharacter("Warrior", "Linus", 0, false);
        }

        [TestMethod]
        public void TestGameOptionsSaveLoad()
        {
            GameOption GameOption = new GameOption();
            Warrior warrior = (Warrior)GameOption.createCharacter("Warrior", "Linus", 7, false);
            Warrior warrior2 = (Warrior)GameOption.createCharacter("Warrior", "Bert", 254, true);
            string path = "D:/Overig/warrior.bin";
            GameOption.Save(path, warrior);
            warrior2 = (Warrior)GameOption.Load(path, warrior2);
            Assert.AreEqual(warrior.Name, warrior2.Name);
            Assert.AreEqual(warrior.Age, warrior2.Age);
            Assert.AreEqual(warrior.Armor, warrior2.Armor);
            Assert.AreEqual(warrior.Health, warrior2.Health);
        }
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestGameOptionsSaveDoesntExist()
        {
            GameOption GameOptions = new GameOption();
            Character character = GameOptions.createCharacter("Warrior", "Linus", 7, false);
            GameOptions.Save("dingennzo.bin", character);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsSaveWithoutPath()
        {
            GameOption GameOptions = new GameOption();
            Character character = GameOptions.createCharacter("Warrior", "Linus", 7, false);
            GameOptions.Save("", character);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsSaveWithoutCharacter()
        {
            GameOption GameOptions = new GameOption();
            GameOptions.Save("Linus", null);
        }
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestGameOptionsLoadDoesntExist()
        {
            GameOption GameOptions = new GameOption();
            Character character = GameOptions.createCharacter("Warrior", "Linus", 7, false);
            GameOptions.Load("dingennzo.bin", character);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsLoadWithoutPath()
        {
            GameOption GameOptions = new GameOption();
            Character character = GameOptions.createCharacter("Warrior", "Linus", 7, false);
            GameOptions.Load("", character);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGameOptionsLoadPathIsNull()
        {
            GameOption GameOptions = new GameOption();
            Character character = GameOptions.createCharacter("Warrior", "Linus", 7, false);
            GameOptions.Load(null, character);
        }
    }
}
