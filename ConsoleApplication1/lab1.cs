using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the edge of the cube: ");
            double a = double.Parse(Console.ReadLine());//ввод значения ребра куба
            if (a > 0)//проверка существует ли куб
            { 
                double V = a * a * a; //считаем объем
                double S = 4 * a * a; //считаем площадь боковой поверхности
                Console.WriteLine("Cube volume: " + Math.Round(V, 5)); //вывод
                Console.WriteLine("Side surface area: " + Math.Round(S, 5)); //вывод
            }
            else
            {
                Console.WriteLine("Unreal");
            }
        }
    }
}