using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void TestWarriorCanBeCreated()
        {
            Warrior warrior = new Warrior("Linus", 9, false, 0);
            Assert.AreEqual("Linus", warrior.Name);
            Assert.AreEqual(9, warrior.Age);
            Assert.AreEqual(false, warrior.Admin);
        }
        [TestMethod]
        public void TestWarriorUseRage()
        {
            Warrior warrior = new Warrior("Linus", 9, false, 0);
            Assert.AreEqual(50, warrior.UseRage(50));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestWarriorNoName()
        {
            Warrior warrior = new Warrior(null, 9, false, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestWarriorEmptyName()
        {
            Warrior warrior = new Warrior("", 9, false, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWarriorNegativeAge()
        {
            Warrior warrior = new Warrior("Linus", -12, false, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWarriorAgeIsZero()
        {
            Warrior warrior = new Warrior("Linus", 0, false, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWarriorUseRageNegativeValue()
        {
            Warrior warrior = new Warrior("Linus", 678, false, 0);
            warrior.UseRage(-3);
        }
    }
}
