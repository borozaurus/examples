using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public enum Size
    {
        S, M, L, XL = 10, XXL
    }

    [Flags]
    public enum Location
    {
        Left = 1, Right = 2, Top = 4, Bottom = 8
    }

    public class TShirt
    {
        public Size Size { get; }

        public Location? PictureLocation { get; }

        public TShirt(Size size, Location? pictureLocation = null)
        {
            Size = size;
            PictureLocation = pictureLocation;
        }
    }

    public static class Test05
    {
        public static void DoTest()
        {
            var myFirs = new TShirt(Size.L);
            var current = new TShirt(Size.XL);

            if (myFirs.Size == current.Size)
            {
                Console.WriteLine("You had the same TShirt");
            }
            else
            {
                Console.WriteLine($"Your first t-shirt was {myFirs.Size} and now {current.Size}");
            }

            //add switch

            var asNumer = (int)myFirs.Size;
            Console.WriteLine(asNumer);


            var topRight = Location.Top | Location.Right;

            if (topRight.HasFlag(Location.Bottom))
            {
                Console.WriteLine("Not bottom");
            }
            if (topRight.HasFlag(Location.Top))
            {
                Console.WriteLine("yes to top");
            }
        }
    }
}
