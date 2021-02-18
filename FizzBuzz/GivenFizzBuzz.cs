using System;
using Shouldly;
using Xunit;

namespace FizzBuzz
{
    public class GivenFizzBuzz
    {
        [Fact]
        public void ShouldConvertOneToOneAsString()
        {
            var result = FizzBuzz.Convert(1);
            result.ShouldBe("1");
        }
    }

    public static class FizzBuzz
    {
        public static string Convert(int number)
        {
            throw new NotImplementedException();
        }
    }
}