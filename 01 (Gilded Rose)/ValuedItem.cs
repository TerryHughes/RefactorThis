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

                if (this.Item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
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
            }
        }

        public override void UpdateSellIn()
        {
            this.Item.SellIn = this.Item.SellIn - 1;

            if (this.Item.SellIn < 0)
            {
                if (this.Item.Name == "Aged Brie")
                {
                    if (this.Item.Quality < 50)
                    {
                        this.Item.Quality = this.Item.Quality + 1;
                    }
                }

                if (this.Item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    this.Item.Quality = this.Item.Quality - this.Item.Quality;
                }
            }
        }
    }
}
