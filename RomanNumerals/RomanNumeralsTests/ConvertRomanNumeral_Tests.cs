using System;
using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData('I', 1)]
        [InlineData('V', 5)]
        [InlineData('X', 10)]
        [InlineData('L', 50)]
        [InlineData('C', 100)]
        [InlineData('D', 500)]
        [InlineData('M', 1000)]
        public void Should_Return1IfRomanNumeralIIsPassed(char romanNumeral, int value)
        {
            int number = RomanNumeral.ConvertRomanNumeral(romanNumeral);

            number.Should().Be(value);
        }

        [Fact]
        public void Should_ThrowAnExceptionIfNullIsPassed()
        {
            Action action = () => RomanNumeral.ConvertRomanNumeral('\0');

            action.Should().Throw<Exception>();
        }


        [Fact]
        public void ShouldThrowExceptionIfNegativeCharacter()
        {
            Action action = () => RomanNumeral.ConvertRomanNumeral('-');

            action.Should().Throw<Exception>();
        }


        [Theory]
        [InlineData('v', 5)]
        [InlineData('x', 10)]
        [InlineData('c', 100)]
        public void Should_AcceptLowerCaseLettersAsValidRomanNumerals(char romanNumeral, int value)
        {
            int number = RomanNumeral.ConvertRomanNumeral(romanNumeral);

            number.Should().Be(value);
        }


        [Fact]
        public void Should_ValidatedIfStringPassedIsEmpty()
        {
            int number = RomanNumeral.ConvertRomanNumeral(' ');
            number.Should().Be(0);
        }

       
    }
}