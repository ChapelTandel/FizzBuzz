using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLib;

namespace FizzBuzzConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FizzBuzzCalculator fizzBuzzer = new FizzBuzzCalculator();
            List<string> fizzBuzzItems = fizzBuzzer.Calculate(Enumerable.Range(1,100));
            fizzBuzzItems.ForEach(f => Console.WriteLine(f));

            Console.ReadKey();

        }
    }
}