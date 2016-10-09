using System;

namespace _6MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double sqr = GetMathPower(number, power);
            Console.WriteLine(sqr);
        }

        public static double GetMathPower(double n, double p)
        {
            double result = 1;
            for (int i = 1; i <= p; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
