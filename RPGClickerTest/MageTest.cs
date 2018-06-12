using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class MageTest
    {
        [TestMethod]
        public void TestMageCanBeCreated()
        {
            Mage mage = new Mage("Linus", 9, false, 200);
            Assert.AreEqual("Linus", mage.Name);
            Assert.AreEqual(9, mage.Age);
            Assert.AreEqual(false, mage.Admin);
            Assert.AreEqual(200, mage.Mana);
        }
        [TestMethod]
        public void TestMageUseSpell()
        {
            Mage mage = new Mage("Linus", 9, false, 200);
            Assert.AreEqual(mage.ClickDamage*4, mage.UseSpell(200));
            Assert.AreEqual(160, mage.Mana);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMageNoName()
        {
            Mage mage = new Mage(null, 9, false, 200);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMageEmptyName()
        {
            Mage mage = new Mage("", 9, false, 200);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMageNegativeAge()
        {
            Mage mage = new Mage("Linus", -12, false, 200);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMageAgeIsZero()
        {
            Mage mage = new Mage("Linus", 0, false, 200);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMageUseSpellNegativeMana()
        {
            Mage mage = new Mage("Linus", 3, false, 200);
            mage.UseSpell(-3);
        }
    }
}        
                                       