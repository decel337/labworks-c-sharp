using System;

namespace lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            int n = 1;
            double sum = p(x, n);
            if (x > 0 && x < 2)
            {
                while (Math.Abs(p(x, n + 1) - p(x, n)) > Math.Pow(10, -6))
                {
                    n ++;
                    sum += p(x, n);
                }
                Console.WriteLine(Math.Round(sum + p(x, n+1), 6));
            }
            else
                Console.WriteLine("ОШИБКА! Введите число х є (0;2)");
        }    

        private static double p(double x, int n)
        {
            return Math.Pow(-1, n - 1) * Math.Pow(x - 1, n) / n;
        }
    }
}