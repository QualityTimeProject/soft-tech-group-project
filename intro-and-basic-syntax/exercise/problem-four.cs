using System;

namespace P04_BeverageLabels
{
    public class P04_BeverageLabels
    {
        public static void Main(string[] args)
        {
            //We recieve from the Console the product name -> a string;
            var product = Console.ReadLine();

            //In the next three lines,we recieve volume,energy and sugar content of our product,as and integer;
            var vol = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            //We calculate...
            double totalEnergy = energyPer100ml / 100.0 * vol;
            double totalSugar = sugarPer100ml * vol / 100.0;

            //TODO
            Console.WriteLine("{0}ml {1}:", vol, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
