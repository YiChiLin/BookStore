using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BookStore
{
    internal class HarryPotterSeries 
    {
        private int NumberOfBooks { get; set; }
        private IEnumerable<Books> Books { get; set; }

        public HarryPotterSeries(int numberOfNumberOfBook)
        {
            NumberOfBooks = numberOfNumberOfBook;
        }

        public HarryPotterSeries(IEnumerable<Books> books)
        {
            Books = books;
        }

        internal decimal GetPrice()
        {
            var distinctBooks = Books.GroupBy(b => b.Name)
                .Where(name => name.Count() == 1)
                .Select(group => @group.Key).ToList();

            var duplicateBooks = Books.GroupBy(b => b.Name)
                .Where(name => name.Count() > 1)
                .Select(group => new { @group.Key, Count = @group.Count() }).ToList();

            return CaculatePrice(distinctBooks.Count) + CaculatePrice(duplicateBooks.Count);
        }

        private decimal CaculatePrice(int booksQuantity)
        {
            switch (booksQuantity)
            {
                case 5:
                    return (decimal) (100*5*0.75);
                case 4:
                    return (decimal) (100*4*0.8);
                case 3:
                    return (decimal) (100*3*0.9);
                case 2:
                    return (decimal) (100*2*0.95);
                case 0:
                    return 0;
                default:
                    return 100;
            }
        }

    }
}
