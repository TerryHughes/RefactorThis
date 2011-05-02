namespace RefactorThis.GildedRose
{
    public class ValuedItem : ExtendedItem
    {
        public ValuedItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (this.Item.Quality < 50)
            {
                this.Item.Quality = this.Item.Quality + 1;
            }
        }

        public override void UpdateSellIn()
        {
            this.Item.SellIn = this.Item.SellIn - 1;

            if (this.Item.SellIn < 0)
            {
                if (this.Item.Quality < 50)
                {
                    this.Item.Quality = this.Item.Quality + 1;
                }
            }
        }
    }
}
