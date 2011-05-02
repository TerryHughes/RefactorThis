namespace RefactorThis.GildedRose
{
    public class ExtendedItem
    {
        protected readonly Item Item;

        public ExtendedItem(Item item)
        {
            this.Item = item;
        }

        public virtual void UpdateQuality()
        {
            if (this.Item.Quality > 0)
            {
                this.Item.Quality--;
            }
        }

        public virtual void UpdateSellIn()
        {
            this.Item.SellIn--;

            if (this.Item.SellIn < 0)
            {
                this.UpdateQuality();
            }
        }
    }
}
