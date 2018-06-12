using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class SummonerTest
    {
        [TestMethod]
        public void TestSummonerCanBeCreated()
        {
            Summoner summoner = new Summoner("Linus", 9, false);
            Assert.AreEqual("Linus", summoner.Name);
            Assert.AreEqual(9, summoner.Age);
            Assert.AreEqual(false, summoner.Admin);
        }
        [TestMethod]
        public void TestSummonerSummonMinion()
        {
            Summoner summoner = new Summoner("Linus", 9, false);
            Assert.AreEqual(true, summoner.SummonMinion(0, 3));
        }
        [TestMethod]
        public void TestSummonerSummonMinionCooldownIsHigherThanZero()
        {
            Summoner summoner = new Summoner("Linus", 9, false);
            Assert.AreEqual(false, summoner.SummonMinion(1, 3));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSummonerNoName()
        {
            Summoner summoner = new Summoner(null, 9, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSummonerEmptyName()
        {
            Summoner summoner = new Summoner("", 9, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSummonerNegativeAge()
        {
            Summoner summoner = new Summoner("Linus", -12, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSummonerAgeIsZero()
        {
            Summoner summoner = new Summoner("Linus", 0, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSummonerSummonMinionNegativeClickDamage()
        {
            Summoner summoner = new Summoner("Linus", 3, false);
            summoner.SummonMinion(0, -3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSummonerSummonMinionZeroClickDamage()
        {
            Summoner summoner = new Summoner("Linus", 3, false);
            summoner.SummonMinion(0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSummonerSummonMinionNegativeCooldown()
        {
            Summoner summoner = new Summoner("Linus", 3, false);
            summoner.SummonMinion(-3, 5);
        }
    }
}
