using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMe.Model;
using TestMe.Service;

namespace TestMe.Logic
{
    public class BankLogic
    {
        private readonly IDataAccess _dataAccess;

        public BankLogic(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void CreateAccount(string owner)
        {
            var account = new BankAccount()
            {
                OwnerName = owner,
                Number = 20837401,
                Value = 0
            };
            _dataAccess.SaveBankAccount(account);
        }

        public string GetAccountData()
        {
            try
            {
                var account = _dataAccess.LoadBankAccount(1);
                return $"Bank account own by {account.OwnerName} {Environment.NewLine}" +
                       $"Number {account.Number} {Environment.NewLine}" +
                       $"Value {account.Value}";
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

        public void DepositAmount(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException ("amount should be greater then 0");

            var account = _dataAccess.LoadBankAccount(1);

            account.Value += amount;

            _dataAccess.SaveBankAccount(account);
        }

        public bool WithrowAmount(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("amount should be greater then 0");

            var account = _dataAccess.LoadBankAccount(1);

            if (account.Value < amount)
                return false;

            account.Value -= amount;
            _dataAccess.SaveBankAccount(account);
            return true;
        }

    }
}
