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
                new string[] { "foo" },
                new int[] { 0 },
                new int[] { 0 });
        }

        public string DoUpdateQuality(string name, int sellIn, int quality)
        {
            return "";
        }
    }
}