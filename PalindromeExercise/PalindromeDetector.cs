namespace PalindromeExercise;

public class PalindromeDetector
{
    public static bool StringIsPalindrome(string input)
    {
        var inputLettersOnly = RemoveNonLettersFromString(input);
        var lowerCaseLettersOnly = inputLettersOnly.ToLower();
        var reversedLowerCaseLettersOnly = ReverseString(inputLettersOnly).ToLower();

        return lowerCaseLettersOnly == reversedLowerCaseLettersOnly;
    }

    private static string RemoveNonLettersFromString(string input)
    {
        return new string(input.Where(c => char.IsLetter(c)).ToArray());
    }

    private static string ReverseString(string input)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i.ToString());
        }

        return new string(input.Reverse().ToArray());
    }
}