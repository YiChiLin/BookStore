using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BookStore.Tests
{
    [TestClass()]
    public class HarryPotterSeriesTests
    {
        [TestMethod()]
        public void Buy_1_HarryPotterBook_Is_NT100()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
            };
            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_2_Different_HarryPotterBooks_Is_NT190()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
                new Books(){Name = "HarryPotter2"}
            };
            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_3_Different_HarryPotterBooks_Is_NT270()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
                new Books(){Name = "HarryPotter2"},
                new Books(){Name = "HarryPotter3"}
            };
            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_4_Different_HarryPotterBooks_Is_NT320()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
                new Books(){Name = "HarryPotter2"},
                new Books(){Name = "HarryPotter3"},
                new Books(){Name = "HarryPotter4"}
            };
            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_Complete_Series_HarryPotterBooks_Is_NT375()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
                new Books(){Name = "HarryPotter2"},
                new Books(){Name = "HarryPotter3"},
                new Books(){Name = "HarryPotter4"},
                new Books(){Name = "HarryPotter5"}
            };
            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_3_Different_And_1_Is_Duplicate_HarryPotterBooks_Is_NT370()
        {
            var shoppingCart = new List<Books>()
            {
                new Books(){Name = "HarryPotter1"},
                new Books(){Name = "HarryPotter2"},
                new Books(){Name = "HarryPotter3"},
                new Books(){Name = "HarryPotter4"},
                new Books(){Name = "HarryPotter4"}
            };

            var target = new HarryPotterSeries(shoppingCart);
            var actual = target.GetPrice();
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }
    }
}
