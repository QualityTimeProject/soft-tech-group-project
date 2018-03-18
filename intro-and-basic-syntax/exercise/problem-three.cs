using System;

namespace MilesToKm
{
    class MilesToKm
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());

            Console.WriteLine($"{mile * 1.60934:f2}");
        }
    }
}
