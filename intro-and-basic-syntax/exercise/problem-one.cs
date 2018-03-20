//CONFIRMED from iani4ka
using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a string to hold the debit card number
            string debitCardNumber = "";

            // Loop 4 times
            for (int i = 0; i < 4; i++)
            {
                // Read from the Console a string and parse it to an integer
                int integerNumber = int.Parse(Console.ReadLine());
                // Pad the number with zeroes and add it to the end of the output string
                debitCardNumber += integerNumber.ToString().PadLeft(4, '0') + " ";
            }

            // Print the resulting string
            Console.WriteLine(debitCardNumber);
        }
    }
}
