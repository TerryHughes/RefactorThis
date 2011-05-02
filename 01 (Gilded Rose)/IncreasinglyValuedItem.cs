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
                base.UpdateQuality();
            }

            if (this.Item.SellIn < 6)
            {
                base.UpdateQuality();
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
