namespace GildedRose_VC
{
    public class ConjuredItem : Item
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            int qualityChange = SellIn < 0 ? -4 : -2;
            Quality = Math.Max(0, Math.Min(Quality + qualityChange, 50));
        }
    }
}
