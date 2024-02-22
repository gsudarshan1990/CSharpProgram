using CSharpUnitTestPractice;


namespace BankUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_Validation()
        {
            //Arrange
            double initial_balance = 11.23;
            double debit = 5.13;
            double expected = 6.1;
            BankAccount bankAccount = new BankAccount("Ram", initial_balance);

            //Act
            bankAccount.Debit(debit);

            //Assert
            Assert.AreEqual(Math.Round(bankAccount.Balance, 1), expected);


        }
    }
}