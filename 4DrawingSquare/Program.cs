using System;

namespace _4DrawingSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            PrintMiddleRows(n);
            PrintFooter(n);
        }

        static void PrintMiddleRows(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write('-');
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }
        static void PrintFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
