using TestMe.Model;

namespace TestMe.Service
{
    public interface IDataAccess
    {
        BankAccount LoadBankAccount(int id);
        void SaveBankAccount(BankAccount account);
    }
}