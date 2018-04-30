using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Scripts
{
    class CheckingAccount : BankAccount
    {
        public float transactionFee = 0.005f;

        public void Fee()
        {
            money -= money * transactionFee;
        }

        public string GetFee()
        {
            return "Fee: " + (transactionFee * 100).ToString();
        }

        public override float Withdraw(float amount)
        {
            amount = base.Withdraw(amount);
            Fee();
            return amount;
        }

        public override string GetStatement()
        {
            return base.GetStatement() + "\n" + "\t" + GetFee() + "\n";
        }
    }
}
