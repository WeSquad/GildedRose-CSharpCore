using Xunit;
using System.Collections.Generic;
using ApprovalTests.Reporters;
using ApprovalTests;
using ApprovalTests.Combinations;
using System;

namespace csharpcore
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityTest()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new string[] { "foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" },
                new int[] { 0, -1, 5, 11 },
                new int[] { 0, 1, -2, 2 });
        }

        private static string DoUpdateQuality(string name, int sellIn, int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            return app.Items[0].ToString();
        }
    }
}