using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class PalindromeDetector
    {
        public bool StringIsPalindrome(string input)
        {
            bool result = false;

            string inputLettersOnly = String.Join("", input.Where( c => char.IsLetter(c)));
            string lowerCaseLettersOnly = inputLettersOnly.ToLower();
            string reversedLowerCase = string.Join("", inputLettersOnly.ToLower().Reverse());
            result = lowerCaseLettersOnly == reversedLowerCase;

            return result;  
        }
    }
}
