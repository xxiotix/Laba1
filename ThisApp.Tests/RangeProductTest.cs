using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAppforArrays;

namespace MyAppforArrays.Tests
{
    [TestClass]
    public class RangeProductTest
    {
        [TestMethod]
        public void Calculate_ReturnsProductOfNumbersDivisibleBy14()
        {
            RangeProduct r = new RangeProduct(1, 50);

            long result = r.Calculate();

            Assert.AreEqual(14 * 28 * 42, result);
        }

        [TestMethod]
        public void Calculate_NoNumbersDivisibleBy14_Returns0()
        {
            RangeProduct r = new RangeProduct(1, 10);

            long result = r.Calculate();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_AandBSwapped_ReturnsCorrectResult()
        {
            RangeProduct r = new RangeProduct(50, 1);

            long result = r.Calculate();

            Assert.AreEqual(14 * 28 * 42, result);
        }

        [TestMethod]
        public void Constructor_OneParameter_SetsCorrectRange()
        {
            RangeProduct r = new RangeProduct(10);

            Assert.AreEqual(10, r.A);
            Assert.AreEqual(20, r.B);
        }
    }
}
