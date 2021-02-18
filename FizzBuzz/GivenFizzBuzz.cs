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

        [Fact]
        public void ShouldReturnFizzFor3()
        {
            var result = FizzBuzz.Convert(3);
            result.ShouldBe("Fizz");
        }
        
        
        [Fact]
        public void ShouldReturnFizzFor6()
        {
            var result = FizzBuzz.Convert(6);
            result.ShouldBe("Fizz");
        }
    }

    public static class FizzBuzz
    {
        public static string Convert(int number)
        {
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}