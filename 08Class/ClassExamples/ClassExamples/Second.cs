using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Second
    {
        private readonly StringBuilder _stringBuilder;

        public Second()
        {
            _stringBuilder = new StringBuilder();
        }

        public void AddLine(int i)
        {
            _stringBuilder.AppendLine("" + i);
        }
        public void AddLine(string i)
        {
            _stringBuilder.AppendLine(i);
        }

        public void AddLine(double i)
        {
            _stringBuilder.AppendLine(""+i);
        }

        public string ReturnAll()
        {
            return _stringBuilder.ToString();
        }
    }

    public static class Test02
    {
        public static void DoTest()
        {
            var second = new Second();
            second.AddLine(3);
            second.AddLine(3.5);
            second.AddLine("boom");


            Console.WriteLine(second.ReturnAll());
        }
    }
}
