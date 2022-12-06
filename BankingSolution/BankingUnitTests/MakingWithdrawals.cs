namespace BankingUnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void MakingWithdrawalsDecreasesBalance(decimal amountToWithdrawal)
        {

            //Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            //When

            account.Deposit(amountToWithdrawal);

            //Then
            Assert.Equal(amountToWithdrawal - openingBalance, account.GetBalance());
        }
    }
}

