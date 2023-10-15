using GildedRose_VC;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Gilded Rose Inn!");

        var items = new List<Item>
        {
            new RegularItem("+5 Dexterity Vest", 10, 20),
            new AgedBrieItem("Aged Brie", 2, 0),
            new RegularItem("Elixir of the Mongoose", 5, 7),
            new BackstagePassItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
            new ConjuredItem("Conjured Mana Cake", 3, 6),
            new LegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80) // Sulfuras as a Legendary item
        };

        var gildedRose = new GildedRose(items);

        int days = 30; // Number of days for which you want to update item quality

        for (int day = 1; day <= days; day++)
        {
            Console.WriteLine($"Day {day}:");

            Console.WriteLine("Name, SellIn, Quality");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            }

            gildedRose.UpdateQuality();
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
