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
    }
}
