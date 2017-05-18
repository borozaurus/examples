using TestMe.Model;

namespace TestMe.Service
{
    public interface IDataAccess
    {
        BankAccount LoadBankAccount();
        void SaveBankAccount(BankAccount account);
    }
}