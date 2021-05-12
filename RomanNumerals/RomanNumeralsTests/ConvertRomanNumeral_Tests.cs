using System;
using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("I",1)]
        // [InlineData("V",5)]
        public void Should_Return1IfRomanNumeralIIsPassed(string romanNumeral, int value)
        {
            int number = RomanNumeral.ConvertRomanNumeral(romanNumeral);

            number.Should().Be(value);
        }

        [Fact]
        public void Should_ThrowAnExceptionIfNullIsPassed()
        {
            Action action = () => RomanNumeral.ConvertRomanNumeral(null);

            action.Should().Throw<NullReferenceException>();
        }
    }
}
