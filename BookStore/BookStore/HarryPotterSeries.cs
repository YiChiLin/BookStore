namespace BookStore
{
    internal class HarryPotterSeries 
    {
        private int Books { get; set; }

        public HarryPotterSeries(int numberOfBook)
        {
            Books = numberOfBook;
        }

        internal decimal CaculateTotalPrice()
        {
            return 100;
        }
    }
}
