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
                if (value < 0)
                    throw new Exception("thios should be >=0");
               
                _someNumer = value;
            }
        }

        public First(int i)
        {
            SomeNumber = i;
        }

        public int DoSomething(int incre)
        {
            SomeNumber += incre;
            return 9;
        }
    }

    public static class Test01
    {
        public static void DoTest()
        {
            var first = new First(3);
            first.SomeNumber = 2323;
            first.DoSomething(2);
            
            System.Console.WriteLine($"This is a number {first.SomeNumber}");
        }
    }
}
