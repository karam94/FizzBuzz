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
        public void ShouldConvertMultipleOf3AsFizz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }
        
        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void ShouldConvertMultipleOf5AsBuzz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }
        
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void ShouldConvertMultipleOf3And5AsFizzBuzz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }
    }

    public static class FizzBuzz
    {
        public static string Convert(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
            if (number % 5 == 0) return "Buzz";
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}