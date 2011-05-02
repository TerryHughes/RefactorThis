namespace RefactorThis.GildedRose
{
    public class ExtendedItem
    {
        protected readonly Item Item;

        public ExtendedItem(Item item)
        {
            this.Item = item;
        }

        public void UpdateQuality()
        {
        }

        public void UpdateSellIn()
        {
        }
    }
}
