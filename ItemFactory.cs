using System;

namespace csharpcore
{
    public static class ItemFactory
    {
        public static Item Create(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new AgedBrie(sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new Backstage(sellIn, quality);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(sellIn, quality);
                default:
                    return new Item(name, sellIn, quality);
            }
        }
    }
}
