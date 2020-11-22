using System;
namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Console.Write("Input natural value n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Reciprocal numbers with " + n + ": ");
            for (int i = 0; i < n; i++)
            {
                int p = n;
                int k = i;
                while (p!=0 && k!=0)
                {
                    if (p>k)
                        p = p % k;
                    else
                        k = k % p;
                    if (p + k == 1)
                        Console.Write(i+" ");
                }
            }
        }
    }
}