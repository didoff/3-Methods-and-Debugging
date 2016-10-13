using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8MultiplyEvensByOdds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultiplicationOfEvensAndOdds(number));
        }


        public static int GetMultiplicationOfEvensAndOdds(int n)
        {
            int evens = GetSumOfEvens(n);
            int odds = GetSumOfOdds(n);
            return evens * odds;
        }

        public static int GetSumOfOdds(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }

        public static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }
    }
}
