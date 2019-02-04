using System;

namespace csharpcore
{
    public class Item
    {
        [Obsolete("Use parametered constructor")]
        public Item() { }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return $"Name:{ Name }, SellIn:{ SellIn}, Quality:{ Quality }";
        }

        public virtual void UpdateSellInAndQuality()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 1;
                }
            }
        }
    }
}
