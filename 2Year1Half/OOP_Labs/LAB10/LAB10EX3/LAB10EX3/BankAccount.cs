using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX3
{
    class BankAccount : Account
    {
        public string name;
        public double money;

        public void createAccount(string name, double money)
        {
            this.name = name;
            this.money = money;
        }

        public void deleteAccount(List<BankAccount> bankAccounts, BankAccount bankAccount)
        {
            bankAccounts.Remove(bankAccount);
        }
    }
}
