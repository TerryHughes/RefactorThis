namespace RefactorThis.GildedRose
{
    public class ConjuredItem : ExtendedItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            base.UpdateQuality();

            if (Item.Quality > 0)
            {
                Item.Quality = Item.Quality - 1;
            }
        }
    }
}
