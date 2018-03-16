
using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double sum = height * width;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}

