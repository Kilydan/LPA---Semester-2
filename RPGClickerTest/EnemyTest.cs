using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class EnemyTest
    {
        [TestMethod]
        public void TestEnemyCreateEnemy()
        {
            Enemy enemy = new Enemy("Slime", 10, 3);
            Assert.AreEqual("Slime", enemy.Name);
            Assert.AreEqual(10, enemy.Health);
            Assert.AreEqual(3, enemy.Damage);
        }
        [TestMethod]
        public void TestEnemyDropChanceItemDrops()
        {
            Enemy enemy = new Enemy("Slime", 10, 3);
            Assert.AreEqual(true, enemy.OnDeathEvent(100));
        }
        [TestMethod]
        public void TestEnemyDropChanceItemDoesntDrops()
        {
            Enemy enemy = new Enemy("Slime", 10, 3);
            Assert.AreEqual(false, enemy.OnDeathEvent(0));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEnemyNameIsNull()
        {
            Enemy enemy = new Enemy(null, 10, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEnemyNameIsEmpty()
        {
            Enemy enemy = new Enemy("", 10, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEnemyDamageIsBelowZero()
        {
            Enemy enemy = new Enemy("Slime", 10, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEnemyDamageIsZero()
        {
            Enemy enemy = new Enemy("Slime", 10, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEnemyHealthIsZero()
        {
            Enemy enemy = new Enemy("Slime", 0, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEnemyHealthIsBelowZero()
        {
            Enemy enemy = new Enemy("Slime", -3, 3);
        }
    }
}
