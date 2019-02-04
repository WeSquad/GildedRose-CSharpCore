using Xunit;
using System.Collections.Generic;
using ApprovalTests.Reporters;
using ApprovalTests.Combinations;
using System;

namespace csharpcore
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityNameUnchangedTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void TestUseOfApprovalTests()
        {
           CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new string[] { "foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert" },
                new int[] { 0, -1, 6, 11, 8 },
                new int[] { 0, 1, 2 });
        }

        public string DoUpdateQuality(string name, int sellIn, int quality)
        {
            Item item = new Item { Name = name, SellIn = sellIn, Quality = quality };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            return item.ToString();
        }
    }
}