using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class UpgradeTest
    {
        [TestMethod]
        public void TestUpgradeCreateUpgrade()
        {
            Upgrade upgrade = new Upgrade("name", "ClickDamage", 5);
            Assert.AreEqual("name", upgrade.Name);
            Assert.AreEqual("ClickDamage", upgrade.UpgradeType);
            Assert.AreEqual(5, upgrade.Value);
        }
        [TestMethod]
        public void TestUpgradeBuyPrice()
        {
            Upgrade upgrade = new Upgrade("name", "ClickDamage", 5);
            Assert.AreEqual(upgrade.price, upgrade.BuyPrice());
            upgrade.TimesBought++;
            int expectedVal = (upgrade.price * upgrade.TimesBought) + upgrade.price;
            Assert.AreEqual(expectedVal, upgrade.BuyPrice());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestUpgradeNameIsNull()
        {
            Upgrade upgrade = new Upgrade(null, "ClickDamage", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestUpgradeNameIsEmpty()
        {
            Upgrade upgrade = new Upgrade("", "ClickDamage", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestUpgradeTypeIsNull()
        {
            Upgrade upgrade = new Upgrade("name", null, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestUpgradeTypeIsEmpty()
        {
            Upgrade upgrade = new Upgrade("name", "", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestUpgradeValueIsZero()
        {
            Upgrade upgrade = new Upgrade("name", "ClickDamage", 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestUpgradeValueIsBelowZero()
        {
            Upgrade upgrade = new Upgrade("name", "ClickDamage", -5);
        }
    }
}
