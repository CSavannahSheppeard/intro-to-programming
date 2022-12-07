namespace Banking.Domain;

public enum BankAccountType {  Standard, Gold };
public class BankAccount
{
    public BankAccountType AccountType = BankAccountType.Standard;
    private decimal _balance = 5000; //  "Fields" "class level variables"
    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = AccountType == BankAccountType.Standard ? 0 : amountToDeposit + bonus;

        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            // TODO
            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
    }
}
