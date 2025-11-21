using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAppforArrays;

namespace MyAppforArrays.Tests
{
    [TestClass]
    public class ThreeNumbersTest
    {
        [TestMethod]
        public void Calculate_AllGreaterThan15_ReturnsProduct()
        {
            ThreeNumbers t = new ThreeNumbers(20, 17, 30);

            long result = t.Calculate();

            Assert.AreEqual(20 * 17 * 30, result);
        }

        [TestMethod]
        public void Calculate_NotAllGreaterThan15_ReturnsSquareOfSum()
        {
            ThreeNumbers t = new ThreeNumbers(10, 20, 30);

            long result = t.Calculate();

            Assert.AreEqual((10 + 20 + 30) * (10 + 20 + 30), result);
        }

        [TestMethod]
        public void Constructor_OneParameter_AssignsValueCorrectly()
        {
            ThreeNumbers t = new ThreeNumbers(5);

            Assert.AreEqual(5, t.A);
            Assert.AreEqual(0, t.B);
            Assert.AreEqual(0, t.C);
        }
    }
}
