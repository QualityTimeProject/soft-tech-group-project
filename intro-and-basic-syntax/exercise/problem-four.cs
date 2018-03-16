using System;

namespace P04_BeverageLabels
{
    public class P04_BeverageLabels
    {
        public static void Main(string[] args)
        {
            //We recieve from the Console the product name -> a string;
            strig product = Console.ReadLine();
            
            //In tne next three lines,we recieve volume,energy and sugar content of our product,as and integer;
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            //We calculate..
            double totalEnergy = energyPer100ml / 100.0 * volume;
            double totalSugar = sugarPer100ml * volume / 100.0;

            //TODO
            Console.WriteLine("{0}ml {1}:", volume, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
