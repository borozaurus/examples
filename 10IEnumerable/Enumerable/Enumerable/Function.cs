using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class MyAwsomeMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLog
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = AddExecute(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = SubExecute(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }


        private int AddExecute(int a, int b)
        {
            return a + b;
        }

        private int SubExecute(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLogNoDuplication
    {
        public int Add(int a, int b)
        {
            return Log(AddExecute, a, b);
        }

        public int Sub(int a, int b)
        {
            return Log(SubExecute, a, b);
        }

        private int Log(Func<int, int, int> operation, int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = operation(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }

        private int AddExecute(int a, int b)
        {
            return a + b;
        }

        private int SubExecute(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLogNoDuplicationAndLambda
    {
        public int Add(int a, int b)
        {
            return Log((i, j) =>
            {
                return i + j;
            }, a, b);
        }

        public int Sub(int a, int b)
        {
            return Log((i, j) => i - j, a, b);
        }

        private static int Log(Func<int, int, int> operation, int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = operation(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }
    }

    public static class Function
    {

        public static void RunTest()
        {
            new MyAwsomeMath().Add(3, 5);
            new MyAwsomeMathWithLog().Add(3, 5);
            new MyAwsomeMathWithLogNoDuplication().Add(3, 5);
            new MyAwsomeMathWithLogNoDuplicationAndLambda().Add(3, 5);
        }
    }
}
