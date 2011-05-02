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

            return new ExtendedItem(item);
        }
    }
}
