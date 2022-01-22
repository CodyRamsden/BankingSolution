using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    public class SavingsAccount : Account {

        public decimal InterestRate { get; set; } = .12m;

        public decimal CalculateAndPayInterest(int MonthsToPay) {
            var Interest = InterestRate / 12 * MonthsToPay * Balance;
            Deposit(Interest);
            return Interest;
        }

    }
}
