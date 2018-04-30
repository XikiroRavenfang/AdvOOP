using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance.Scripts;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingsAccount());
            accounts.Add(new CheckingAccount());

            accounts[0].Deposit(100);
            accounts[1].Deposit(100);

            accounts[1].Withdraw(24);

            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.GetStatement());
            }
            Console.ReadLine();
        }
    }
}
