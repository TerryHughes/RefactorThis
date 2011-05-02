namespace RefactorThis.GildedRose
{
    public class ItemFactory
    {
        public ExtendedItem Create(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new LegendaryItem(item);
            }

            if (item.Name == "Aged Brie")
            {
                return new ValuedItem(item);
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new IncreasinglyValuedItem(item);
            }

            return new ExtendedItem(item);
        }
    }
}
