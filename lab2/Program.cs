using System;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
// Given number x, y. (x, y) ?c G, G - initial set
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            double y = double.Parse(Console.ReadLine());
            if ((y >= (1 - x) && x <= 0) || (y >= (1 - x) && y <= 0))
                Console.Write("Belong to G");
            else
                Console.Write("Not belong to G");
        }
    }
}