using System;
using Shouldly;
using Xunit;

namespace FizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            false.ShouldBeTrue();
        }
    }
}