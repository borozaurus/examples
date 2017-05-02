using System;
using System.IO;

namespace IO
{
    internal static class FileTest
    {
        public static void OneLine()
        {
            var testPath = Path.GetTempFileName();

            string text = "Save me!";
            File.WriteAllText(testPath, text);

            var result = File.ReadAllText(testPath);

            System.Console.WriteLine(result);
        }

        public static string WriteLineByLine()
        {
            
            string[] lines = { "First line", "Second line", "Third line" };

            var tmpFile = Path.GetTempFileName();
            
            using (StreamWriter outputFile = new StreamWriter(tmpFile))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            return tmpFile;
        }

        public static void ReadLineByLine(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteToFile()
        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileinfo = new System.IO.FileInfo("C:\\file.txt");
            try
            {
                file = fileinfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Check for null because OpenWrite might have failed.
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        public static void Execute()
        {
            OneLine();

            var fileName = WriteLineByLine();
            ReadLineByLine(fileName);
        }
    }
}