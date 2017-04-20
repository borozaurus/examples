using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Inter
{
    public interface IPersonDataProvider
    {
        List<Person> GetAllData();
    }
}
