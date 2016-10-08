using System;

namespace _6MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double sqr = GetMathPower(number, power);
            Console.WriteLine(sqr);
        }

        private static double GetMathPower(int n, int p)
        {
            //Write it W/ Math.Pow!!!!

            int result = 0;
            for (int i = 1; i <= p; i++)
            {
                result = n*i;
            }
            return result;
        }
    }
}
