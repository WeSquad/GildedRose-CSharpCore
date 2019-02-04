using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public class Backstage : Item
    {
        public Backstage(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
        }

        public override void UpdateSellInAndQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;

                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
