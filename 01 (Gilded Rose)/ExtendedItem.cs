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
                this.Item.Quality = this.Item.Quality - 1;
            }
        }

        public virtual void UpdateSellIn()
        {
            this.Item.SellIn = this.Item.SellIn - 1;

            if (this.Item.SellIn < 0)
            {
                if (this.Item.Quality > 0)
                {
                    this.Item.Quality = this.Item.Quality - 1;
                }
            }
        }
    }
}
