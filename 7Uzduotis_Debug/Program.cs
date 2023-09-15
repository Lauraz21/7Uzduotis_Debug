using System;
namespace _7Uzduotis_Debug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
        public static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}
