using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMe.Logic;
using TestMe.Service;

namespace TestMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            var bankLogic = new BankLogic(dataAccess);

            int number = 10;
            while (number != 0)
            {
                Console.WriteLine("Awsome bank system");
                Console.WriteLine("1 - Create account");
                Console.WriteLine("2 - Show account info");
                Console.WriteLine("3 - Deposit");
                Console.WriteLine("4 - Withdrow");
                Console.WriteLine("0 - Exit");

                var input = Console.ReadLine();
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Not a number");
                    continue;
                }

                try
                {
                    ProcessDecision(number, bankLogic);
                }
                catch (InvalidAmountException e)
                {
                    Console.WriteLine("Something want wrong!!! "+ e.Message);
                }
            }
        }

        private static void ProcessDecision(int number, BankLogic bankLogic)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter owner");
                    var owner = Console.ReadLine();
                    bankLogic.CreateAccount(owner);
                    break;
                case 2:
                    var data = bankLogic.GetAccountData();
                    Console.WriteLine(data);
                    break;
                case 3:
                    Console.WriteLine("Enter amount to deposit");
                    var depositText = Console.ReadLine();
                    decimal deposit = 0;
                    if (Decimal.TryParse(depositText, out deposit))
                    {
                        bankLogic.DepositAmount(deposit);
                    }
                    else
                    {
                        Console.WriteLine("Not a number");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter amount to withdrow");
                    var withdrowText = Console.ReadLine();
                    decimal withdrow = 0;
                    if (decimal.TryParse(withdrowText, out withdrow))
                    {
                        Console.WriteLine(bankLogic.WithrowAmount(withdrow) ? "Success!" : "Failure!");
                    }
                    else
                    {
                        Console.WriteLine("Not a number");
                    }
                    break;

                case 0:
                    Console.WriteLine("Thanks");
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
        }
    }
}
