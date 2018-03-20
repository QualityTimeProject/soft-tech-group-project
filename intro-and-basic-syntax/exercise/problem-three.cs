//CONFIRMED from VladiG1984
using System;

namespace MilesToKm
{
    class MilesToKm
    {
        static void Main(string[] args)
        {
            // read a string from the Console and parse it to a double
            double mile = double.Parse(Console.ReadLine());

            // calculate the result, format it with two digits after the decimal point and print it to the Console
            Console.WriteLine($"{mile * 1.60934:f2}");
        }
    }
}
