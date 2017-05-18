using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestMe.Model;

namespace TestMe.Service
{
    public class DataAccess : IDataAccess
    {
        private const string FileName = "account.json";

        public BankAccount LoadBankAccount()
        {
            var fileBody = File.ReadAllText(FileName);
            return JsonConvert.DeserializeObject<BankAccount>(fileBody);
        }

        public void SaveBankAccount(BankAccount account)
        {
            var fileBody = JsonConvert.SerializeObject(account);
            File.WriteAllText(FileName, fileBody);
        }

    }
}
