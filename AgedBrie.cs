using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public class AgedBrie : Item
    {
        public const string ItemName = "Aged Brie";

        public AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality)
        {
        }
        public override void UpdateSellInAndQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }
        }
    }
}
