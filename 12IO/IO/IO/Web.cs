using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class WebTest
    {

        public static void Execute()
        {
            var str = "http://www.cnn.com";

            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                using (var reader = new StreamReader(client.OpenRead(str)))
                {
                    var s = reader.ReadToEnd();
                    Console.WriteLine(s);
                }                
            }
        }

    }
}
