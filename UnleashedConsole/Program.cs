using EnglishCurrencyConverter;
using System;

namespace UnleashedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Amount to English Currency Converter");
            CurrencyConverter currencyConverter = new CurrencyConverter();
            while (true)
            {
                Console.WriteLine("Please enter the amount to be converted");
                string input = Console.ReadLine();
                try
                {
                    Console.WriteLine(currencyConverter.ConvertToEnglishCurrency(input));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
