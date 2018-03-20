//CONFIRMED from VladiG1984
using System;

namespace CharacterStats
{
    class Program
    {
	// Define a method that creates a string with data about the video game character's current state relative to its maximum state.
        static string PrintCurrentToMaxState(int currentState, int maxState)
        {
            string currentToMaxState = '|' + new string('|', currentState) +
                    new string('.', maxState - currentState) + '|';
            return currentToMaxState;
        }

        static void Main(string[] args)
        {
	    // Read data about video game character from console.
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

	    // Output data about character on console as follows: character's name, health, and energy.
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine("Health: " + PrintCurrentToMaxState(currentHealth, maxHealth));
            Console.WriteLine("Energy: " + PrintCurrentToMaxState(currentEnergy, maxEnergy));
        }
    }
}
