namespace GildedRose_VC
{
    public class LegendaryItem : Item
    {
        public LegendaryItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality()
        {
            // Legendary items (e.g., Sulfuras) never change in quality or sell-in
        }
    }
}
