using System;

namespace RomanNumeralsApp
{
    public static class RomanNumeral
    {
        public static int ConvertRomanNumeral(string romanNumeral)
        {
            if (romanNumeral is null)
            {
                throw new NullReferenceException("Enter a non-null roman numeral");
            }
            if (romanNumeral.Length >= 2)
            {
                switch (romanNumeral[..2])
                {
                    case "IV":
                        return 4;
                    case "IX":
                        return 9;
                    case "XL":
                        return 40;
                    case "XC":
                        return 90;
                    case "CD":
                        return 400;
                    case "CM":
                        return 900;
                }
            }
            if (romanNumeral.Length >= 1)
            {
                return romanNumeral[..1] switch
                {
                    "I" => 1,
                    "V" => 5,
                    "X" => 10,
                    "L" => 50,
                    "C" => 100,
                    "D" => 500,
                    "M" => 1000,
                };
            }
            Console.Out.WriteLine("Return 0");
            return 0;
        }

        public static void Main()
        {
        }
    }
}