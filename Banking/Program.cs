using System;

namespace Banking
{
    class Program {
        static void Main(string[] args) {

            var sav1 = new SavingsAccount() {
                Id = 200, Description = "1st Savings"
            };
            sav1.Deposit(100);
            sav1.CalculateAndPayInterest(6);
            Console.WriteLine(sav1);

            var acct1 = new Account() {
                Id = 100, Balance = 1000, Description = "1st Account"
            };

            var acct2 = new Account() {
                Id = 200, Balance = 0, Description = "2nd Account"
            };
            acct1.Deposit(100);
            Console.WriteLine(acct1);
            acct1.Withdraw(20);
            Console.WriteLine(acct1);
            acct1.Transfer(30, acct2);
            Console.WriteLine(acct1);
            Console.WriteLine(acct2);
            
        }
    }
}
