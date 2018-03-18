//CONFIRMED from VladiG1984
// comments added by ad2bg
using System;

namespace P04_BeverageLabels
{
    public class P04_BeverageLabels
    {
        public static void Main(string[] args)
        {
            // We recieve from the Console the product name -> a string:
            var product = Console.ReadLine();

            // In the next three lines, we recieve volume, energy and sugar content of our product, as integers:
            var vol = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            // We calculate the total energy anf the total sugar content
            double totalEnergy = energyPer100ml / 100.0 * vol;
            double totalSugar = sugarPer100ml * vol / 100.0;

            // And finally we print out the results:
            Console.WriteLine("{0}ml {1}:", vol, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
