using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Basic()
        {
            {
                try
                {
                    // Code to try goes here.
                }
                catch (SomeSpecificException ex)
                {
                    // Code to handle the exception goes here.
                    // Only catch exceptions that you know how to handle.
                    // Never catch base class System.Exception without
                    // rethrowing it at the end of the catch block.
                }
            }

            {
                try
                {
                    // Code to try goes here.
                }
                finally
                {
                    // Code to execute after the try block goes here.
                }
            }

            {
                try
                {
                    // Code to try goes here.
                }
                catch (SomeSpecificException ex)
                {
                    // Code to handle the exception goes here.
                }
                finally
                {
                    // Code to execute after the try (and possibly catch) blocks 
                    // goes here.
                }
            }
        }

        public static int GetInt(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new System.ArgumentOutOfRangeException(
                    "Parameter index is out of range.", e);
            }
        }

        public static int DoSomethingSecure()
        {
            try
            {
                throw new UnauthorizedAccessException("You shell not pass");
            }
            catch (System.UnauthorizedAccessException e)
            {
                // Call a custom error logging procedure.
                Console.WriteLine(e.Message);
                
                // Re-throw the error.
                throw;
            }
        }

        static void Main(string[] args)
        {
            Basic();

            try
            {
                GetInt(new[] { 1, 2, 4, 5, 6 }, 20);
            }
            catch (Exception e)
            {
                // bad example 
            }

            try
            {
                DoSomethingSecure();
            }
            catch (Exception e)
            {
                // bad example 
            }
        }
    }
}
