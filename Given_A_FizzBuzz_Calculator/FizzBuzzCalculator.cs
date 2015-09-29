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
                if(number.ToString().Contains("3"))
                    resultList.Add("Fizz");

                else if(number%7 ==0)
                    resultList.Add("Whizz");

                else if (number%3==0 && number%5==0)
                    resultList.Add("FizzBuzz");

                else if (number%3 == 0)
                    resultList.Add("Fizz");

                else if (number%5 == 0)
                    resultList.Add("Buzz");

                else
                    resultList.Add(number.ToString());
            }

            return resultList;
        }
    }
}