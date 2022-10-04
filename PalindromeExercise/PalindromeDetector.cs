using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class PalindromeDetector
    {
        public static bool StringIsPalindrome(string input)
        {
            string inputLettersOnly = RemoveNonLettersFromString(input);
            string lowerCaseLettersOnly = inputLettersOnly.ToLower();
            string reversedLowerCaseLettersOnly = ReverseString(inputLettersOnly).ToLower();
            
            return lowerCaseLettersOnly == reversedLowerCaseLettersOnly;
        }

        private static string RemoveNonLettersFromString(string input)
        {
            return new string(input.Where(c => char.IsLetter(c)).ToArray());
        }

        private static string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
