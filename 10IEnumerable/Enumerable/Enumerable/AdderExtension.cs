namespace Enumerable.Extensions
{
    public static class AdderExtension
    {
        public static int Subtraction(this IAdder adder, int a, int b)
        {
            return adder.Add(a, -b);
        }
    }
}