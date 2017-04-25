using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class CollectionProcessing
    {
        public static void RunTest()
        {
            var list = new List<int> { 3, 1, 10, -39, 0, 12, 43, -3 };

            {
                // select
                var myNewList = list.Select(p => $"({p})");
                Print(myNewList);
            }

            {
                // where
                var myNewList = list.Where(p => p > 0);
                Print(myNewList);
            }

            {
                // Take, Skip
                var myNewList = list.Take(5).Skip(2);
                Print(myNewList);
            }

            {
                // TakeWhile
                var myNewList = list.TakeWhile(p => p > 0);
                Print(myNewList);
            }

            {
                // SkipWhile
                var myNewList = list.SkipWhile(p => p > 0);
                Print(myNewList);
            }

            {
                // Max
                var max = list.Max();
                Console.WriteLine(max);
            }

            {
                // Max
                var min = list.Min();
                Console.WriteLine(min);
            }


            {
                // Count
                var count = list.Count();
                Console.WriteLine(count);
            }

            {
                // Any
                var anyEq = list.Any(p => p == -100);
                Console.WriteLine(anyEq);
            }

            {
                // Group
                var groups = list.GroupBy(p => p >= 0);
                foreach (var group in groups)
                {
                    Console.Write(group.Key + " ");
                    Print(group);
                }
            }

            {
                // Group 
                var groups = list
                    .Select(Math.Abs)
                    .Select(p => new { tens = p / 10, rest = p % 10 })
                    .GroupBy(p => p.tens);

                foreach (var group in groups)
                {
                    Console.Write(group.Key + " and rests ");
                    Print(group.Select(p => p.rest));
                }
            }

            {
                // Aggregation : JUST FYI
                var factorion = System.Linq.Enumerable.Range(1, 10).Aggregate((p, q) => p*q);
                Console.Write(factorion);

            }
            {
                // Aggregation : JUST FYI
                var maxAndMin = list.Aggregate(
                    new
                    {
                        max = Int32.MinValue,
                        min = Int32.MaxValue
                    },
                    (p, q) => new
                    {
                        max = Math.Max(p.max, q),
                        min = Math.Min(p.min, q),
                    });
                Console.Write(maxAndMin.min);
                Console.Write(maxAndMin.max);
            }
        }

        public static void Print<T>(IEnumerable<T> toPrint)
        {
            foreach (var elem in toPrint)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
        }
    }
}
