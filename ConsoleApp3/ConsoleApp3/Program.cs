using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double sum1 = (2 / ((x * x) + 25)) + Math.Cos(x);
            double sum2 = Math.Sqrt((x * x * x * x) + 1) + ((Math.Sin(x) + Math.Cos(x)) / 2);
            double sum3 = sum1 / sum2;
            Console.WriteLine(sum3);

        }
    }
}
