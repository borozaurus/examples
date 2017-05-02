using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Enumerable.Extensions;


namespace Enumerable
{
    public interface IAdder
    {
        int Add(int a, int b);
    }

    public class MyMath : IAdder
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public static class Extension
    {
        public static void RunTest()
        {
            var math = new MyMath();



            System.Console.WriteLine(math.Add(4, 2));
            System.Console.WriteLine(math.Subtraction(4, 2));
        }
    }
}
