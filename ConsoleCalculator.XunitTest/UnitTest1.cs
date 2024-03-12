namespace ConsoleCalculator.XunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new Calculator();

            //Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

            //Assert.Throws<CalculationException>(() => sut.Calculate(1, 2, "+"));

            //Assert.ThrowsAny<CalculationException>(() => sut.Calculate(1, 2, "+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

            Assert.Equal("+", ex.Operation);
        }
    }
}