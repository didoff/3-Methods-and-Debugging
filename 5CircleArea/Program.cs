using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }

        private static double AreaOfCircle(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
}
