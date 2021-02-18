using System;
using Shouldly;
using Xunit;

namespace FizzBuzz
{
    public class GivenFizzBuzz
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void ShouldConvertNumberToAString(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(15, "Fizz")]
        public void ShouldConvertMultipleOf3AsFizz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }

        [Fact]
        public void ShouldConvert5ToBuzz()
        {
            var result = FizzBuzz.Convert(5);
            result.ShouldBe("Buzz");
        }
        
        [Fact]
        public void ShouldConvert10ToBuzz()
        {
            var result = FizzBuzz.Convert(10);
            result.ShouldBe("Buzz");
        }
    }

    public static class FizzBuzz
    {
        public static string Convert(int number)
        {
            if (number % 5 == 0) return "Buzz";
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}