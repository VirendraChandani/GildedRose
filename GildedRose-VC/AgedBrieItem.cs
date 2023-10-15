namespace GildedRose_VC
{
    public class AgedBrieItem : Item
    {
        public AgedBrieItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            Quality = Math.Min(Quality + (SellIn < 0 ? 2 : 1), 50);
        }
    }
}
