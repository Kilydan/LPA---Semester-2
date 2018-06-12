using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGClicker;

namespace RPGClickerTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void TestItemCreateItem()
        {
            Item item = new Item("Rare", "name", "Armor", 5);
            Assert.AreEqual("Rare", item.Rarity);
            Assert.AreEqual("name", item.Name);
            Assert.AreEqual("Armor", item.ItemType);
            Assert.AreEqual(5, item.Value);
        }
        [TestMethod]
        public void TestItemSellItem()
        {
            Item item = new Item("Rare", "name", "Armor", 5);

            bool info = false;
            if (item.SellItem() >= 2* item.Value && item.SellItem() <= 5*item.Value)
            {
                info = true;
            }
            Assert.AreEqual(true, info);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemRarityIsEmpty()
        {
            Item item = new Item("", "name", "Armor", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemRarityIsNull()
        {
            Item item = new Item(null, "name", "Armor", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemNameIsEmpty()
        {
            Item item = new Item("Rare", "", "Armor", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemNameIsNull()
        {
            Item item = new Item("Rare", null, "Armor", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemTypeIsEmpty()
        {
            Item item = new Item("Rare", "name", "", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestItemTypeIsNull()
        {
            Item item = new Item("Rare", "name", null, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestItemValueIsZero()
        {
            Item item = new Item("Rare", "name", "Armor", 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestItemValueIsBelowZero()
        {
            Item item = new Item("Rare", "name", "Armor", -3);
        }
    }
}
