namespace RefactorThis.GildedRose
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static readonly IList<Item> Items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
            };

        private static void Main()
        {
            Assert(new List<int> { 10, 2, 5, 0, 15, 3 }, new List<int> { 20, 0, 7, 80, 20, 6 });
            UpdateQuality();
            Assert(new List<int> { 9, 1, 4, 0, 14, 2 }, new List<int> { 19, 1, 6, 80, 21, 4 });
            UpdateQuality();
            Assert(new List<int> { 8, 0, 3, 0, 13, 1 }, new List<int> { 18, 2, 5, 80, 22, 2 });
            UpdateQuality();
            Assert(new List<int> { 7, -1, 2, 0, 12, 0 }, new List<int> { 17, 4, 4, 80, 23, 0 });
            UpdateQuality();
            Assert(new List<int> { 6, -2, 1, 0, 11, -1 }, new List<int> { 16, 6, 3, 80, 24, 0 });
            UpdateQuality();
            Assert(new List<int> { 5, -3, 0, 0, 10, -2 }, new List<int> { 15, 8, 2, 80, 25, 0 });
            UpdateQuality();
            Assert(new List<int> { 4, -4, -1, 0, 9, -3 }, new List<int> { 14, 10, 0, 80, 27, 0 });
            UpdateQuality();
            Assert(new List<int> { 3, -5, -2, 0, 8, -4 }, new List<int> { 13, 12, 0, 80, 29, 0 });
            UpdateQuality();
            Assert(new List<int> { 2, -6, -3, 0, 7, -5 }, new List<int> { 12, 14, 0, 80, 31, 0 });
            UpdateQuality();
            Assert(new List<int> { 1, -7, -4, 0, 6, -6 }, new List<int> { 11, 16, 0, 80, 33, 0 });
            UpdateQuality();
            Assert(new List<int> { 0, -8, -5, 0, 5, -7 }, new List<int> { 10, 18, 0, 80, 35, 0 });
            UpdateQuality();
            Assert(new List<int> { -1, -9, -6, 0, 4, -8 }, new List<int> { 8, 20, 0, 80, 38, 0 });
            UpdateQuality();
            Assert(new List<int> { -2, -10, -7, 0, 3, -9 }, new List<int> { 6, 22, 0, 80, 41, 0 });
            UpdateQuality();
            Assert(new List<int> { -3, -11, -8, 0, 2, -10 }, new List<int> { 4, 24, 0, 80, 44, 0 });
            UpdateQuality();
            Assert(new List<int> { -4, -12, -9, 0, 1, -11 }, new List<int> { 2, 26, 0, 80, 47, 0 });
            UpdateQuality();
            Assert(new List<int> { -5, -13, -10, 0, 0, -12 }, new List<int> { 0, 28, 0, 80, 50, 0 });
            UpdateQuality();
            Assert(new List<int> { -6, -14, -11, 0, -1, -13 }, new List<int> { 0, 30, 0, 80, 0, 0 });

            for (var i = 0; i < 9; i++)
            {
                UpdateQuality();
            }

            Assert(new List<int> { -15, -23, -20, 0, -10, -22 }, new List<int> { 0, 48, 0, 80, 0, 0 });
            UpdateQuality();
            Assert(new List<int> { -16, -24, -21, 0, -11, -23 }, new List<int> { 0, 50, 0, 80, 0, 0 });
            UpdateQuality();
            Assert(new List<int> { -17, -25, -22, 0, -12, -24 }, new List<int> { 0, 50, 0, 80, 0, 0 });
        }

        // NOTE: This really should be called UpdateInventory.
        private static void UpdateQuality()
        {
            var factory = new ItemFactory();
            foreach (var item in Items.Select(factory.Create))
            {
                item.UpdateQuality();
                item.UpdateSellIn();
            }
        }

        private static void Assert(IList<int> sellIn, IList<int> quality)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].SellIn != sellIn[i] || Items[i].Quality != quality[i])
                {
                    Console.WriteLine(Items[i].Name + " expected " + sellIn[i] + " & " + quality[i] + " but was " + Items[i].SellIn + " & " + Items[i].Quality);
                }
            }
        }
    }
}
