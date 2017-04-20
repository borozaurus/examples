using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Inter
{
    public class Processing
    {
        private readonly IPersonDataProvider _personDataProvider;

        public Processing(IPersonDataProvider personDataProvider)
        {
            _personDataProvider = personDataProvider;
        }

        public void Print()
        {
            var data = _personDataProvider.GetAllData();
            foreach (var person in data)
            {
                System.Console.WriteLine($"this is {person.FirstName} {person.LastName}");
            }
        }
    }

    public static class Test01
    {
        public static void DoTest()
        {
            new Processing(new DBDataProvider()).Print();

            new Processing(new MemoryDataProvider()).Print();
        }
    }
}
