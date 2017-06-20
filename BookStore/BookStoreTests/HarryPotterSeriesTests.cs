using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BookStore.Tests
{
    [TestClass()]
    public class HarryPotterSeriesTests
    {
        [TestMethod()]
        public void Buy_1_HarryPotterBook_Is_NT100()
        {
            var numberOfBook = 1;
            var target = new HarryPotterSeries(numberOfBook);
            var actual = target.CaculateTotalPrice();
            var expected = 100;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void Buy_2_Different_HarryPotterBooks_Is_NT190()
        {
            var numberOfBook = 2;
            var target = new HarryPotterSeries(numberOfBook);
            var actual = target.CaculateTotalPrice();
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_3_Different_HarryPotterBooks_Is_NT270()
        {
            var numberOfBook = 3;
            var target = new HarryPotterSeries(numberOfBook);
            var actual = target.CaculateTotalPrice();
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_4_Different_HarryPotterBooks_Is_NT320()
        {
            var numberOfBook = 4;
            var target = new HarryPotterSeries(numberOfBook);
            var actual = target.CaculateTotalPrice();
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }
    }
}
