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

            if (item.Name == "Aged Brie" || item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new ValuedItem(item);
            }

            return new ExtendedItem(item);
        }
    }
}
