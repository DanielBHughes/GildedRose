using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(2, Items[0].Quality);
        }

        [Test]
        public void backstagePass1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes", SellIn = -1, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void backstagePass2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 9, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].SellIn);
            Assert.AreEqual(4, Items[0].Quality);
        }

        [Test]
        public void sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 2, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(2, Items[0].SellIn);
            Assert.AreEqual(2, Items[0].Quality);
        }

        [Test]
        public void normalItem1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "A normal item", SellIn = -1, Quality = 55 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(50, Items[0].Quality);
        }

        [Test]
        public void normalItem2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "A normal item", SellIn = 2, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(1, Items[0].Quality);
        }

        [Test]
        public void invalidItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "INVALID ITEM", SellIn = 2, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("NO SUCH ITEM", Items[0].Name);
        }

        [Test]
        public void conjured1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = 2, Quality = 2 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void conjured2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = -1, Quality = 5 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(1, Items[0].Quality);
        }


        [Test]
        public void NormalItemNegativeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "some item", SellIn = -1, Quality = 10 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(8, Items[0].Quality);
        }



    }
}
