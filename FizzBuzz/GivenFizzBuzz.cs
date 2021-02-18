using System;
using Shouldly;
using Xunit;

namespace FizzBuzz
{
    public class GivenFizzBuzz
    {
        [Fact]
        public void ShouldConvert1To1AsString()
        {
            var result = FizzBuzz.Convert(1);
            result.ShouldBe("1");
        }

        [Fact]
        public void ShouldConvert2To2AsString()
        {
            var result = FizzBuzz.Convert(2);
            result.ShouldBe("2");
        }
        
        [Fact]
        public void ShouldConvert4To4AsString()
        {
            var result = FizzBuzz.Convert(4);
            result.ShouldBe("4");
        }
    }

    public static class FizzBuzz
    {
        public static string Convert(int number)
        {
            return number.ToString();
        }
    }
}