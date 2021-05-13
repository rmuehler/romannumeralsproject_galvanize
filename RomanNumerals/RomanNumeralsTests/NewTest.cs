using System;
using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class NewTest
    {


        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void Should_SubtractIfSecondCharacterIsGreater(string romanNumeral, int value)
        {
            int number = RomanNumeral.Convert(romanNumeral);
        
            number.Should().Be(value);
        }



        [Fact]
        public void Should_AddIfSecondCharacterIsLessThanFirstCharacter()
        {
            int number = RomanNumeral.Convert("iv");

            number.Should().Be(4);
        }

        
        
        [Fact]
        public void Should_ThrowAnExceptionIfNullIsPassed()
        {
            Action action = () => RomanNumeral.Convert(null);

            action.Should().Throw<NullReferenceException>();
        }

        // [Fact]
        // public void test()
        // {
        //
        //    // Action action = () => RomanNumeral.Convert("CDLXXXMMMDCXLVIII");
        //     int number = RomanNumeral.Convert("CDLXXXMMMDCXLVIII");
        //
        //    // action.Should().Throw<OverflowException>();
        //     number.Should().Be(2006);
        //
        // }
        
        [Fact]
        public void Should_ThrowAnExceptionIfMaxRomanNumeralIsHit()
        {
            Action action = () => RomanNumeral.Convert("MMMM");
            action.Should().Throw<ArgumentOutOfRangeException>();

        }

    }
}