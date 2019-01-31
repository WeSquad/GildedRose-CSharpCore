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
            var name = "foo";
            var sellIn = 0;
            var quality = 0;

            DoUpdateQuality(name, sellIn, quality);

            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new string[] { name },
                new int[] { sellIn },
                new int[] { quality });
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