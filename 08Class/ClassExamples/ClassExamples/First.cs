using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class First
    {
        private int _someNumer;

        public int SomeNumber
        {
            get
            {
                return _someNumer;
            }
            set
            {
                _someNumer = value;
            }
        }

        public First()
        {
            SomeNumber = 4;
        }

        public void DoSomething(int i)
        {
            SomeNumber += i;
        }
    }

    public static class Test01
    {
        public static void DoTest()
        {
            var first = new First();
            first.DoSomething(2);
            
            System.Console.WriteLine($"This is a number {first.SomeNumber}");
        }
    }
}
