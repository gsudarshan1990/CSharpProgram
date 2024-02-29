using ConsoleCalculator;

namespace ConsoleCalculatorTest.Nunit
{
    public class CalculatorShould
    {


        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            Calculator operation = new Calculator();

            //Assert.That(() => operation.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupported>());

            Assert.That(() => operation.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupported>().With.Property("Operation").EqualTo("+"));
        }
    }
}