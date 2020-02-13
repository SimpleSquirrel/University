using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX3
{
    interface Account
    {
        void createAccount(string name, double money);
        void deleteAccount(List<BankAccount> bankAccounts, BankAccount bankAccount);
    }
}
