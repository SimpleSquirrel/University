using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX3
{
    class DepositAccount : BankAccount
    {
        public void giveMoney(double money)
        {
            this.money += money;
        }

        public void takeMoney(double money)
        {
            if (money > this.money)
            {
                Console.WriteLine("Too large amount of money!");
                Console.WriteLine("Taking everything from the acc...");
                this.money = 0;
            }
            else
            {
                this.money -= money;
            }
        }
    }
}
