using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Accessors
    {
        private static int _totalNumber = 0;

        protected int _instanceNumber = 0;

        private Accessors(int instanceNumber)
        {
            _instanceNumber = instanceNumber;
        }

        public static Accessors GetInstance()
        {            
            return new Accessors(_totalNumber++);
        }

        public void WhoAreYou()
        {
            System.Console.WriteLine($"I'm {_instanceNumber} of {_totalNumber}");
        }
    }

    public static class Test04
    {
        public static void DoTest()
        {
            var first = Accessors.GetInstance();
            first.WhoAreYou();

            Accessors.GetInstance().WhoAreYou();
            Accessors.GetInstance().WhoAreYou();

            first.WhoAreYou();
        }
    }
}
