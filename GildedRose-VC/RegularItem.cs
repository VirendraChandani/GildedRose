namespace GildedRose_VC
{
    public class RegularItem : Item
    {
        public RegularItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            int qualityChange = SellIn <= 0 ? -2 : -1;
            Quality = Math.Max(0, Math.Min(Quality + qualityChange, 50));
        }
    }
}
