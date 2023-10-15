namespace GildedRose_VC.Tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void RegularItem_UpdateQuality_SellInGreaterThanZero_QualityDecreases()
        {
            // Arrange
            var item = new RegularItem("+5 Dexterity Vest", 10, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(9, item.SellIn);
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void RegularItem_UpdateQuality_SellInZero_QualityDecreasesTwice()
        {
            // Arrange
            var item = new RegularItem("+5 Dexterity Vest", 0, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(-1, item.SellIn);
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void RegularItem_UpdateQuality_QualityNeverNegative()
        {
            // Arrange
            var item = new RegularItem("+5 Dexterity Vest", 0, 0);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void RegularItem_UpdateQuality_QualityNeverExceeds50()
        {
            // Arrange
            var item = new RegularItem("+5 Dexterity Vest", 2, 55);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(1, item.SellIn);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void AgedBrieItem_UpdateQuality_QualityIncreases()
        {
            // Arrange
            var item = new AgedBrieItem("Aged Brie", 2, 0);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(1, item.SellIn);
            Assert.Equal(1, item.Quality);
        }

        [Fact]
        public void AgedBrieItem_UpdateQuality_QualityNeverExceeds50()
        {
            // Arrange
            var item = new AgedBrieItem("Aged Brie", 2, 50);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(1, item.SellIn);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void BackstagePassItem_UpdateQuality_SellInGreaterThanTen_QualityIncreasesByOne()
        {
            // Arrange
            var item = new BackstagePassItem("Backstage passes to a TAFKAL80ETC concert", 15, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(14, item.SellIn);
            Assert.Equal(21, item.Quality);
        }

        [Fact]
        public void BackstagePassItem_UpdateQuality_QualityIncreasesByTwoWithin10Days()
        {
            // Arrange
            var item = new BackstagePassItem("Backstage passes to a TAFKAL80ETC concert", 10, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(9, item.SellIn);
            Assert.Equal(22, item.Quality);
        }

        [Fact]
        public void BackstagePassItem_UpdateQuality_QualityIncreasesByThreeWithin5Days()
        {
            // Arrange
            var item = new BackstagePassItem("Backstage passes to a TAFKAL80ETC concert", 5, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(4, item.SellIn);
            Assert.Equal(23, item.Quality);
        }

        [Fact]
        public void BackstagePassItem_UpdateQuality_QualityDropsToZeroAfterConcert()
        {
            // Arrange
            var item = new BackstagePassItem("Backstage passes to a TAFKAL80ETC concert", 0, 20);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void ConjuredItem_UpdateQuality_QualityDecreasesByTwo()
        {
            // Arrange
            var item = new ConjuredItem("Conjured Mana Cake", 3, 6);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(2, item.SellIn);
            Assert.Equal(4, item.Quality);
        }

        [Fact]
        public void LegendaryItem_UpdateQuality_NoChangeInQualityOrSellIn()
        {
            // Arrange
            var item = new LegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80);
            var items = new List<Item> { item };
            var gildedRose = new GildedRose(items);

            // Act
            gildedRose.UpdateQuality();

            // Assert
            Assert.Equal(0, item.SellIn);
            Assert.Equal(80, item.Quality);
        }
    }
}
