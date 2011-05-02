namespace RefactorThis.GildedRose
{
    public class IncreasinglyValuedItem : ValuedItem
    {
        public IncreasinglyValuedItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            base.UpdateQuality();

            if (this.Item.SellIn < 11)
            {
                if (this.Item.Quality < 50)
                {
                    this.Item.Quality = this.Item.Quality + 1;
                }
            }

            if (this.Item.SellIn < 6)
            {
                if (this.Item.Quality < 50)
                {
                    this.Item.Quality = this.Item.Quality + 1;
                }
            }
        }

        public override void UpdateSellIn()
        {
            base.UpdateSellIn();

            if (this.Item.SellIn < 0)
            {
                this.Item.Quality = this.Item.Quality - this.Item.Quality;
            }
        }
    }
}
