//CONFIRMED from ad2bg
using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input rectangle's parameters from console.
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            
            // Calculate rectangle's area.
            double area = height * width;
            
            // Output result with precision up to two decimal places.
            Console.WriteLine("{0:F2}", area);
        }
    }
}

