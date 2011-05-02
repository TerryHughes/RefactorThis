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
            if (this.Item.Name != "Aged Brie" && this.Item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (this.Item.Quality > 0)
                {
                    this.Item.Quality = this.Item.Quality - 1;

                    if (this.Item.Name == "Conjured Mana Cake")
                    {
                        this.Item.Quality = this.Item.Quality - 1;
                    }
                }
            }
            else
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
        }

        public virtual void UpdateSellIn()
        {
            this.Item.SellIn = this.Item.SellIn - 1;

            if (this.Item.SellIn < 0)
            {
                if (this.Item.Name != "Aged Brie")
                {
                    if (this.Item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (this.Item.Quality > 0)
                        {
                            this.Item.Quality = this.Item.Quality - 1;
                        }
                    }
                    else
                    {
                        this.Item.Quality = this.Item.Quality - this.Item.Quality;
                    }
                }
                else
                {
                    if (this.Item.Quality < 50)
                    {
                        this.Item.Quality = this.Item.Quality + 1;
                    }
                }
            }
        }
    }
}
