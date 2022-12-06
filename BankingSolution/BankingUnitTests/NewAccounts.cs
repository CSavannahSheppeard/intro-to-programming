namespace BankingUnitTests;
using Banking.Domain;
public class NewAccounts
{
    [Fact]
    public void HaveTheCorrectOpeningBalance()
    {
        //Write the code you wish you had (WTCYWYH)

        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        // When
        account.Deposit(amountToDeposit);
        // Then
        Assert.Equal(5000M, balance);

    }
}