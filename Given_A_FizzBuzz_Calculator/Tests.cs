using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Given_A_FizzBuzz_Calculator
{
    [TestFixture]
    public class When_I_Pass_One
    {
        [Test]
        public void Then_The_Response_Is_One()
        {
            var expected = new List<string> {"1"};
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(1, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_Two
    {
        [Test]
        public void Then_The_Result_Is_Two()
        {
            var expected = new List<string> {"2"};
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(2, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_Three
    {
        [Test]
        public void Then_The_Result_Is_Fizz()
        {
            var expected = new List<string> {"Fizz"};
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(3, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_A_Range_From_1_To_3
    {
        [Test]
        public void Then_The_Result_Is_1_2_Fizz()
        {
            var expected = new List<string> {"1", "2", "Fizz"};
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(1, 3));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_Five
    {
        [Test]
        public void Then_The_Result_Is_Five()
        {
            var expected = new List<string> { "Buzz" };
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(5, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_A_Number_That_Is_Divisible_By_Three_And_Five
    {
        [Test]
        public void Then_The_Result_Is_FizzBuzz()
        {
            var expected = new List<string> { "FizzBuzz" };
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(15, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_A_Range_From_1_To_15
    {
        [Test]
        public void Then_The_Result_Is_()
        {
            var expected = new List<string> { "1", "2","Fizz","4","Buzz","Fizz", "Whizz", "8","Fizz","Buzz","11","Fizz","Fizz","Whizz", "FizzBuzz" };
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(1, 15));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_Seven
    {
        [Test]
        public void Then_The_Result_Is_Whizz()
        {
            var expected = new List<string> { "Whizz" };
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(7, 1));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class When_I_Pass_A_Range
    {
        [TestCase(23,1,"Fizz")]
        [TestCase(25,1,"Buzz")]
        [TestCase(1,15, "1,2,Fizz,4,Buzz,Fizz,Whizz,8,Fizz,Buzz,11,Fizz,Fizz,Whizz,FizzBuzz")]
        public void Then_The_Result_Is(int rangeStart, int rangeLength, string expectedWord)
        {
            var expected = expectedWord.Split(',').ToList();
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            var actual = fizzBuzzCalculator.Calculate(Enumerable.Range(rangeStart, rangeLength));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

}