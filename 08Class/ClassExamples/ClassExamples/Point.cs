using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public struct Point
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }
    }


    public static class Test06
    {
        public static void MoveToLeft(Point p)
        {
            p.X += 5;
        }

        public static void MoveDown(ref Point p)
        {
            p.Y -= 5;
        }


        public static void DoTest()
        {
            var point = new Point() {X = 5, Y = -3};
            MoveToLeft(point);
            MoveDown(ref point);

            Console.WriteLine($"Point is at {point.X} x {point.Y}");            
        }
    }
}
