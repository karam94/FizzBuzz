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
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(11, "11")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(971, "971")]
        [InlineData(1337, "1337")]
        public void ShouldConvertNonMultipleOf3Or5NumberToAString(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(327, "Fizz")]
        public void ShouldConvertMultipleOf3ToFizz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(1000, "Buzz")]
        public void ShouldConvertMultipleOf5ToBuzz(int numberToConvert, string expected)
        {
            var result = FizzBuzz.Convert(numberToConvert);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(1500, "FizzBuzz")]
        [InlineData(3000, "FizzBuzz")]
        public void ShouldConvertMultipleOf3And5ToFizzBuzz(int numberToConvert, string expected)
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
            return number % 3 == 0 ? "Fizz" : number.ToString();
        }
    }
}