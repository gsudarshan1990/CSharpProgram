namespace ConsoleCalculator.Test
{
    public class Tests
    {

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            //Assert.That(() => sut.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>());

            //Assert.That( () => sut.Calculate(1, 3 , "+"), Throws.TypeOf<CalculationOperationNotSupportedException>()
            //    .With
            //    .Property("Operation").EqualTo("+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

            Assert.That(ex!.Operation, Is.EqualTo("+"));

            //Assert.That(() => sut.Calculate(1, 2, "+"), Throws.TypeOf<CalculationException>());

        }
    }
}