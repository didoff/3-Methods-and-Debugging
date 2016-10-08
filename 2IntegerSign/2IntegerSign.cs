using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2IntegerSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IntegerSign(n);
        }

        static void IntegerSign(int number)
        {
            if (number == 0)
                Console.WriteLine("The number {0} is zero.", number);
            else if (number > 0)
                Console.WriteLine("The number {0} is positive.", number);
            else
                Console.WriteLine("The number {0} is negative.", number);
        }
    }
}
