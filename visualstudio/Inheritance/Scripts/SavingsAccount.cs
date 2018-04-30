using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Scripts
{
    class SavingsAccount : BankAccount
    {
        public float interest = 0.004f;

        public void Credit()
        {
            money += money * interest;
        }

        public string GetInterest()
        {
            return "Interest: " + (interest * 100).ToString() + "%";
        }

        public override void Deposit(float amount)
        {
            base.Deposit(amount);
            // Yay money!
            Credit();
        }

        public override string GetStatement()
        {
            return base.GetStatement() +"\n" + "\t" + GetInterest() + "\n";
        }
    }
}
