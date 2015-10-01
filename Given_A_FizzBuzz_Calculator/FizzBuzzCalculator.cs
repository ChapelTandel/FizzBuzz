using System;
using System.Collections.Generic;

namespace Given_A_FizzBuzz_Calculator
{
    public class FizzBuzzCalculator
    {
        public List<string> Calculate(IEnumerable<int> numberList)
        {
            var resultList = new List<string>();
            foreach (var number in numberList)
            {
                GetReplacementValue(number, resultList);
            }
            return resultList;
        }

        private static void GetReplacementValue(int number, List<string> resultList)
        {
            ThrowExceptionIfValueIsZero(number);

            if (ContainsThree(number))
                resultList.Add("Fizz");

            else if (DivisibleBy7(number))
                resultList.Add("Whizz");

            else if (DivisibleBy3and5(number))
                resultList.Add("FizzBuzz");

            else if (DivisibleBy3(number))
                resultList.Add("Fizz");

            else if (DivisibleBy5(number))
                resultList.Add("Buzz");

            else
                resultList.Add(number.ToString());
        }

        private static bool DivisibleBy5(int number)
        {
            return IsDivisibleBy(number,5);
        }

        private static bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }


        private static bool DivisibleBy3(int number)
        {
            return IsDivisibleBy(number,3);
        }

        private static bool DivisibleBy3and5(int number)
        {
            return DivisibleBy5(number) && DivisibleBy3(number);
        }

        private static bool DivisibleBy7(int number)
        {
            return IsDivisibleBy(number, 7);
        }

        private static bool ContainsThree(int number)
        {
            return number.ToString().Contains("3");
        }

        private static void ThrowExceptionIfValueIsZero(int number)
        {
            if (number == 0)
                throw new ArgumentException("Please pass a positive integer");
        }
    }
}