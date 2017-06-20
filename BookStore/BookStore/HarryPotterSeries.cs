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
            switch (Books)
            {
                case 4:
                    return (decimal) (100*4*0.8);
                case 3:
                    return (decimal) (100*3*0.9);
                case 2:
                    return (decimal) (100*2*0.95);
                default:
                    return 100;
            }
        }
    }
}
