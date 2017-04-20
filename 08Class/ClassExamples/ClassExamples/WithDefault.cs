using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class WithDefault
    {
        private int _sum = 0;

        public void AddNumer(int a, int b = 0, int c = 0)
        {
            _sum += a;
            _sum += b;
            _sum += c;
        }

        public int Result()
        {
            return _sum;
        }
    }

    public class WithParams
    {
        private int _sum = 0;

        public void AddNumer(params int[] a)
        {
            foreach (var i in a)
            {
                _sum += i;
            }
        }

        public int Result()
        {
            return _sum;
        }

    }

    public static class Test03
    {
        public static void DoTest()
        {
            var defaults = new WithDefault();
            defaults.AddNumer(5);
            defaults.AddNumer(5, 6);
            defaults.AddNumer(5, c: 7);
            System.Console.WriteLine(""+ defaults.Result());

            var param = new WithParams();
            param.AddNumer(5);
            param.AddNumer(5, 6);
            param.AddNumer(5, 6, 7);
            param.AddNumer(5, 6, 7, 8);
            System.Console.WriteLine("" + param.Result());
        }
    }
}
