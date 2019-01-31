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
        public void FooItemTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void TestUseOfApprovalTests()
        {
            var names = new[] { "Llewellyn", "James", "Dan", "Jason", "Katrina" };
            Array.Sort(names);
            Approvals.VerifyAll(names, "");
        }
    }
}