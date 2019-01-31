using Xunit;
using System.Collections.Generic;
using ApprovalTests.Reporters;
using ApprovalTests;
using System;

namespace csharpcore
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Approvals.Verify(Items[0].ToString());
        }
    }
}