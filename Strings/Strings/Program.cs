using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            // string
            string text = "This is some text";

            Console.WriteLine(text);

            ///////////////////////////////////////////////////////////////
            // string
            var text2 = "This is some text too";

            Console.WriteLine(text2);

            ///////////////////////////////////////////////////////////////
            // concatenation
            var text3 = "This is "
                        + "some text too";

            Console.WriteLine(text3);

            ///////////////////////////////////////////////////////////////
            // casting
            var text4_1 = "This is text with " + 5 + " in";
            var text4_2 = string.Concat("This is text with ", 5, " in");
            Console.WriteLine(text4_1);
            Console.WriteLine(text4_2);

            ///////////////////////////////////////////////////////////////
            // formating
            var text5_1 = string.Format("This is text with {0} in", 5);

            Console.WriteLine(text5_1);

            ///////////////////////////////////////////////////////////////
            // formating
            var message = "This is text with {0} in";
            var text5_2 = string.Format(message, 5);

            Console.WriteLine(text5_2);

            ///////////////////////////////////////////////////////////////
            // formating new
            var text6_1 = $"This is text with {5} in";

            Console.WriteLine(text6_1);

            ///////////////////////////////////////////////////////////////
            // new line
            var text7_1 = "Line \n new line";

            Console.WriteLine(text7_1);

            ///////////////////////////////////////////////////////////////
            // new line 
            var text7_2 = "Line " + Environment.NewLine + "new line";

            Console.WriteLine(text7_2);

            ///////////////////////////////////////////////////////////////
            // escape chars
            var text8_1 = "c:\\this\\is\\path";

            Console.WriteLine(text8_1);


            ///////////////////////////////////////////////////////////////
            // string literal
            var text8_2 = @"c:\this\is\path";

            Console.WriteLine(text8_2);

            ///////////////////////////////////////////////////////////////
            // some operations
            var text9 = "this is string";

            Console.WriteLine(text9.Length);
            Console.WriteLine(text9.Substring(5, 2));
            Console.WriteLine(text9.Replace("is", "IS"));
            Console.WriteLine(text9.Contains("is"));
            Console.WriteLine(text9.IndexOf("is"));

            ///////////////////////////////////////////////////////////////
            // some operations
            var somethingLong = "This";
            somethingLong += " is";
            somethingLong += " something";
            somethingLong += " very";
            somethingLong += " long";

            Console.WriteLine(somethingLong);

            var sb = new StringBuilder();
            sb.Append("This");
            sb.Append(" is");
            sb.Append(" something");
            sb.Append(" very");
            sb.Append(" long");

            var somethingLonger = sb.ToString();
            Console.WriteLine(somethingLonger);

            ///////////////////////////////////////////////////////////////
            // reading from resources

            var resourceName = "Strings.TextFile.txt";
            using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)))
            {
                string result = reader.ReadToEnd();
            }
        }
    }
}
