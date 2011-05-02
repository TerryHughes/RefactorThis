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
    }
}
