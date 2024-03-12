using ConsoleCalculator;

namespace CalculateCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Calculator();
            //Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

            Assert.AreEqual("+", ex.Operation);

            Assert.ThrowsException<CalculationException>(() => sut.Calculate(1, 2, "+"));

        }
    }
}