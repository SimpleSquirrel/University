using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            List<CurrentAccount> currentAccounts = new List<CurrentAccount>();
            List<DepositAccount> depositAccounts = new List<DepositAccount>();
            bool close = false;
            int choose;
            while (close == false)
            {
                Console.WriteLine("1 - Создать аккаунт" +
                                  "\n2 - Создать депозинтый аккаунт" +
                                  "\n3 - Вывести все аккаунты" +
                                  "\n4 - Добавить деняк в текущий аккаунт" +
                                  "\n5 - Забрать деняки из текущего аккаунта" +
                                  "\n6 - Добавить деняк в депозитный аккаунт" +
                                  "\n7 - Забрать деняки из депозитного аккаунта" +
                                  "\n8 - Удалить аккаунт" +
                                  "\n9 - Выход");

                Console.Write($"\nВведите операцию:{choose = Int32.Parse(Console.ReadLine())}\n");
                

                switch (choose)
                {
                    case 1:
                        {
                            CurrentAccount currentAccount = new CurrentAccount();
                            Console.WriteLine("Введите название аккаунта и его колово деньжат");
                            currentAccount.createAccount(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
                            currentAccounts.Add(currentAccount);
                            bankAccounts.Add(currentAccount);
                            break;
                        }
                    case 2:
                        {
                            DepositAccount depositAccount = new DepositAccount();
                            Console.WriteLine("Введите название аккаунта и его колово деньжат");
                            depositAccount.createAccount(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
                            depositAccounts.Add(depositAccount);
                            bankAccounts.Add(depositAccount);
                            break;
                        }
                    case 3:
                        {
                            foreach (BankAccount bankAccount in bankAccounts)
                            {
                                Console.WriteLine("Name: " + bankAccount.name);
                                Console.WriteLine("Money: " + bankAccount.money);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите название аккаунта");
                            string accountName = Console.ReadLine();
                            foreach (CurrentAccount currentAccount in currentAccounts)
                            {
                                if (currentAccount.name.Equals(accountName))
                                {
                                    currentAccount.giveMoney(Double.Parse(Console.ReadLine()));
                                    break;
                                }

                            }
                            Console.WriteLine("Такого аккаунта нет");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите название аккаунта");
                            string accountName = Console.ReadLine();
                            foreach (CurrentAccount currentAccount in currentAccounts)
                            {
                                if (currentAccount.name.Equals(accountName))
                                {
                                    currentAccount.takeMoney(Double.Parse(Console.ReadLine()));
                                    break;
                                }

                            }
                            Console.WriteLine("Такого аккаунта нет");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите название аккаунта");
                            string accountName = Console.ReadLine();
                            foreach (DepositAccount depositAccount in depositAccounts)
                            {
                                if (depositAccount.name.Equals(accountName))
                                {
                                    depositAccount.giveMoney(Double.Parse(Console.ReadLine()));
                                    break;
                                }

                            }
                            Console.WriteLine("Такого аккаунта нет");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Введите название аккаунта");
                            string accountName = Console.ReadLine();
                            foreach (DepositAccount depositAccount in depositAccounts)
                            {
                                if (depositAccount.name.Equals(accountName))
                                {
                                    depositAccount.takeMoney(Double.Parse(Console.ReadLine()));
                                    break;
                                }

                            }
                            Console.WriteLine("Такого аккаунта нет");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Введите название аккаунта");
                            string accountName = Console.ReadLine();
                            foreach (BankAccount bankAccount in bankAccounts)
                            {
                                if (bankAccount.name.Equals(accountName))
                                {
                                    bankAccount.deleteAccount(bankAccounts, bankAccount);
                                    break;
                                }

                            }
                            Console.WriteLine("Такого аккаунта нет");
                            break;
                        }
                    case 9:
                        {
                            close = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели что-то не так");
                            break;
                        }

                }
            }
        }
    }
}
