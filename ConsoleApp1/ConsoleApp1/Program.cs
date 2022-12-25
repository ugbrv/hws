using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-й катет: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-й катет: ");
            double b = double.Parse(Console.ReadLine());
            double S = (a * b) / 2;
            double c = Math.Sqrt((a * a) + (b * b));
            double P = (a + b + c);
            Console.WriteLine("Площадь равна = " + S);

            Console.WriteLine("периметр равна = " + P);

        }
    }
}