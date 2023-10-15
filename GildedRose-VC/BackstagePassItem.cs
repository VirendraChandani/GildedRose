namespace GildedRose_VC
{
    public class BackstagePassItem : Item
    {
        public BackstagePassItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            if (SellIn <= 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality = Math.Min(Quality + 3, 50);
            }
            else if (SellIn <= 10)
            {
                Quality = Math.Min(Quality + 2, 50);
            }
            else
            {
                Quality = Math.Min(Quality + 1, 50);
            }
        }
    }
}
