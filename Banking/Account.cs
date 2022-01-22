using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    public abstract class Account {

        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }
        public string Name { get; set; }

        public Account(decimal balance, string name) {
            Balance = balance;
            this.Name = Name;
        }

        private void CheckAmount(decimal Amount) {
            if (Amount <= 0) {
                throw new ArgumentException("Amount cannot be negative or zero");
            }
        }
        public void Transfer(decimal Amount, Account ToAccount) {
            this.Withdraw(Amount);
            ToAccount.Deposit(Amount);
        }

        public void Deposit(decimal Amount) {
            CheckAmount(Amount);
            Balance += Amount;
        }
        public void Withdraw(decimal Amount) {
            CheckAmount(Amount);
            if (Amount > Balance) {
                throw new Exception("Insufficient Funds");
            } 
            Balance -= Amount;
        }
        /*public Account(int Id) {
            this.Id = Id;
        }*/
        public override string ToString() {
            return $"{Id} | {Balance} | {Description}";
        }
    }
}
