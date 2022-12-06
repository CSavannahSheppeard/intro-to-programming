using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingUnitTests
{
    public class WorkingWithMultipleAccounts
    {
        [Fact]

        public void InstancesOfOurAccountsAreIsolated()
        {
            var bobsAccount = new BankAccount();
            var suesAccount = new BankAccount();

            bobsAccount.Deposit(1000M);
            suesAccount.Withdraw(suesAccount.GetBalance());

            Assert.Equal(6000, bobsAccount.GetBalance());
            Assert.Equal(0, suesAccount.GetBalance());



        }
    }
}
