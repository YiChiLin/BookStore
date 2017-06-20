using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BookStore
{
    internal class HarryPotterSeries 
    {
        private IEnumerable<Books> Books { get; set; }

        public HarryPotterSeries(IEnumerable<Books> books)
        {
            Books = books;
        }

        internal decimal GetPrice()
        {
            var groupByBooks = Books.GroupBy(b => b.Name)
                                    .Select(group => new { @group.Key, Count = @group.Count() }).ToList();

            var duplicateBooks = groupByBooks.Select(x => new { Count = x.Count - 1 }).Where(y => y.Count >= 1).Select(x => new { x.Count }).ToList();

            decimal price = 0;
            while (duplicateBooks.Count > 0)
            {
                price += CaculatePrice(duplicateBooks.Count);
                duplicateBooks = duplicateBooks.Where(y => y.Count > 1).Select(x => new { Count = x.Count - 1 }).ToList();
            }

            return CaculatePrice(groupByBooks.Count) + price;
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
                case 1:
                    return 100;
                default:
                    return 0;
            }
        }

    }
}