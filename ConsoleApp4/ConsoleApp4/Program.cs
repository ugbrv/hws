using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static double met(double y1, double y2)
        {
           
            double y = (Math.Sqrt(y1 + Math.Tan(y2))) / (y1 * y1) + (y2 * y2);
            return y;

        }
        static void Main(string[] args)
        {

            double sum1 = met(2,3);
           
            double sum2 = met(7,8); ;
           
            double sum3 = met(1,4);
            
            double sumall = sum1 + sum2 + sum3;
            Console.WriteLine(sumall);
        }
    }
}
