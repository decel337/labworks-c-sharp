using System;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number of term range: ");
            double n = double.Parse(Console.ReadLine());
            double a0 = 1;
            double a = 1;
            for (int i = 1; i < n+1; i++)
            {
                a = (i * a0 + 1) / i;
                a0 = a;
            }

            Console.WriteLine("Value term range: " + Math.Round(a, 6));
        }
    }
}