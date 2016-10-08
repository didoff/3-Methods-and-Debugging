using System;

namespace _5TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        private static double GetTriangleArea(double w, double h)
        {
            return w * h / 2;
        }
    }
}
