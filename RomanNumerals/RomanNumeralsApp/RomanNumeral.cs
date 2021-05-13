using System;

namespace RomanNumeralsApp
{
    public static class RomanNumeral
    {
        public static int ConvertRomanNumeral(char romanNumeral)
        {

            switch (Char.ToUpper(romanNumeral))
            {

                case ' ': return 0;
                case 'I' : return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default:
                case '\0': throw new Exception("Enter a correct Roman Numeral character");
                

            }

            //return 0;
        }

        public static void Main()
        {
        }

        public static int Convert(string romanNumeral)
        {
            
            int answer = 0;

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                

                int num1 = ConvertRomanNumeral(romanNumeral[i]);
                

                if (i + 1 < romanNumeral.Length)
                {
                    int num2 = ConvertRomanNumeral(romanNumeral[i + 1]);

                    if(num2 > num1){
                        answer = answer + num2 - num1;
                        i++;
                    }
                    if(num1 >= num2){
                        answer += num1;
                    }
                }
                else
                {
                    answer += num1;
                    i++;
                }
            }
            
            return answer;
        }
    }
}