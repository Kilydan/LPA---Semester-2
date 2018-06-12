using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class BossTest
    {
        [TestMethod]
        public void TestBossCreateBoss()
        {
            Boss boss = new Boss("Slime", 10, 3, 30);
            Assert.AreEqual("Slime", boss.Name);
            Assert.AreEqual(10, boss.Health);
            Assert.AreEqual(3, boss.Damage);
            Assert.AreEqual(30, boss.Timer);
        }
        [TestMethod]
        public void TestBossTimeUp()
        {
            Boss boss = new Boss("Slime", 10, 3, 30);
            Assert.AreEqual(-50, boss.TimeUp(50));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestBossNameIsNull()
        {
            Boss boss = new Boss(null, 10, 3, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestBossNameIsEmpty()
        {
            Boss boss = new Boss("", 10, 3, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossDamageIsBelowZero()
        {
            Boss boss = new Boss("Slime", 10, -3, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossDamageIsZero()
        {
            Boss boss = new Boss("Slime", 10, 0, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossHealthIsZero()
        {
            Boss boss = new Boss("Slime", 0, 3, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossHealthIsBelowZero()
        {
            Boss boss = new Boss("Slime", -8, 3, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossTimerIsBelowZero()
        {
            Boss boss = new Boss("Slime", 10, 3, -5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossTimerIsZero()
        {
            Boss boss = new Boss("Slime", 10, 3, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBossTimeUpGoldBelowZero()
        {
            Boss boss = new Boss("Slime", 10, 3, 0);
            boss.TimeUp(-3);
        }
    }
}
