namespace csharpcore
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public string ToString()
        {
            return "name: " + Name + ", sell in: " + SellIn + ", quality: " + Quality;
        }
    }
}
