//CONFIRMED from iani4ka
using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console the product name -> 4 integers;
            string debitCardNumber = "";

            //We print them in 4-digit debit card format;
            for (int i = 0; i < 4; i++)
            {
                int integerNumber = int.Parse(Console.ReadLine());
                debitCardNumber += integerNumber.ToString().PadLeft(4, '0') + " ";
            }
            Console.WriteLine(debitCardNumber);
        }
    }
}
