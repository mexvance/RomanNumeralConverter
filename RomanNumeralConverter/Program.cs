using System;
using System.Collections.Generic;

namespace RomanNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralToTextConverter Converter = new RomanNumeralToTextConverter();
            Console.WriteLine("Please enter your value in RomanNumerals");
            var input = Console.In.ReadLine();
            var romanString = input.ToUpper(); 
            if (Converter.IsStringValidRomanNumeralInput(romanString))
            {
                Console.WriteLine("This is your converted value: " + Converter.CalculateTotalRomanNumeralNumber(romanString));
            }
            else
            {
                Console.WriteLine("Sorry your input was invalid, we are exiting now");

            }
        }
    }
}
