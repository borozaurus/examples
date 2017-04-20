using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Inter
{
    public class DBDataProvider : IPersonDataProvider
    {
        public List<Person> GetAllData()
        {
            return new List<Person>()
            {
                new Person() {FirstName = "Wojciech", LastName = "FromDatabase"}
            };
        }
    }
}
