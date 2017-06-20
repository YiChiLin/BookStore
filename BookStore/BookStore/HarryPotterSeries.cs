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
            if (Books == 2)
                return (decimal) (100*2*0.95);
            return 100;
        }
    }
}
