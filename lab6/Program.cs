using System;
using System.Xml.Schema;

namespace lab6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Weight: ");
            int Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("NumberOfVariants: " + Combinations(Weight));
        }

        private static int Combinations(int Weight)
        {
            int [] VariantsOfWeight = {100, 200, 300, 500, 1000, 1200, 1400, 1500, 2000, 3000};
            int NumberOfVariants = 0;
            for (int x = 1; x < Math.Pow(2, VariantsOfWeight.Length ); x++)
            {
                int x1 = x;
                int TempWeight = 0;
                for (int i = 0; i < 10; i++)
                {
                    TempWeight += VariantsOfWeight[i] * (x1 % 2);
                    x1 = x1 / 2;
                }

                if (TempWeight == Weight)
                    NumberOfVariants++;

            }

            return NumberOfVariants;
        }
    }
}