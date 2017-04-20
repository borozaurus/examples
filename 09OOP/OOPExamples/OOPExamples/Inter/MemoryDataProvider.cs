using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Inter
{
    public class MemoryDataProvider : IPersonDataProvider
    {
        public List<Person> GetAllData()
        {
            return new List<Person>()
            {
                new Person() {FirstName = "Piotr", LastName = "FromMemory"}
            };
        }
    }
}
