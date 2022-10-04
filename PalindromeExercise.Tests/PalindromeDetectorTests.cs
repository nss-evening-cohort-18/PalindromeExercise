namespace PalindromeExercise.Tests;

public class PalindromeDetectorTests
{
    [Fact]
    public void StringIsPalindrome_Returns_True_When_Given_Palindrome()
    {
        //Arrange
        string inputString = "tacocat";

        //Act
        bool result = PalindromeDetector.StringIsPalindrome(inputString);

        //Assert
        Assert.True(result);
        
    }

    [Fact]
    public void StringIsPalindrome_Returns_False_When_Given_Non_Palindrome()
    {
        string input = "I am not a palindrome.";

        bool result = PalindromeDetector.StringIsPalindrome(input);

        Assert.False(result);
    }

    [Fact]
    public void StringIsPalindrome_Detects_Palindrome_With_Spaces()
    {
        string input = "taco cat";

        bool result = PalindromeDetector.StringIsPalindrome(input);

        Assert.True(result);
    }

    [Fact]
    public void StringIsPalindrome_Handles_Punctuation()
    {
        string input = "ta.co'C9aT";

        bool result = PalindromeDetector.StringIsPalindrome(input);

        Assert.True(result);
    }

    [InlineData("tAcOCaT", true)]
    [InlineData("I am not a palindrome.", false)]
    [InlineData("t.A1!2@3#4$5%6^7&8*9(0)-_=+;:',<.>/?\"\\|c;OCaT", true)]
    [InlineData("TACOCAT", false)]
    [InlineData("tacocat", true)]
    [Theory]
    public void StringIsPalindrome_Passes_Actual_Palindromes(string input, bool expectedResult)
    {
        bool actualResult = PalindromeDetector.StringIsPalindrome(input);
        Assert.Equal(actualResult, expectedResult);
    }


}