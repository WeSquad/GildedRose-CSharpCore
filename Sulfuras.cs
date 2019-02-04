using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public class Sulfuras : Item
    {
        public Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality)
        {
        }

        public override void UpdateSellInAndQuality()
        {
        }
    }
}
