using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class CompanyBankAccount : BankAccount
    {
        public void TakeLoan(float loan)
        {
            //some implementation
        }

        public override void MakeWithdraw(float amount)
        {
            Console.WriteLine("company bank account withdrawal");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance -= amount;
        }
    }
}
