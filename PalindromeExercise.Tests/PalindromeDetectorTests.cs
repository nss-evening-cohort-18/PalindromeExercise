namespace PalindromeExercise.Tests;

public class PalindromeDetectorTests
{
    [Fact]
    public void StringIsPalindrome_ReturnsTrue_WhenGivenPalindrome()
    {
        //Arrange
        var inputString = "tacocat";
        var expectedResult = true;

        //Act
        var actualResult = PalindromeDetector.StringIsPalindrome(inputString);

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void StringIsPalindrome_ReturnsFalse_WhenGivenNonPalindrome()
    {
        var input = "abcde";
        var expectedResult = false;

        var actualResult = PalindromeDetector.StringIsPalindrome(input);

        Assert.Equal(expectedResult, actualResult);
    }


    [InlineData("taco cat", true)]
    [InlineData("abc de", false)]
    [Theory]
    public void StringIsPalindrome_HandlesSpaces(string input, bool expectedResult)
    {
        var actualResult = PalindromeDetector.StringIsPalindrome(input);

        Assert.Equal(expectedResult, actualResult);
    }

    [InlineData("ta.co'C9aT", true)]
    [InlineData("ab.c'd9e", false)]
    [Theory]
    public void StringIsPalindrome_HandlesPunctuation(string input, bool expectedResult)
    {
        var actualResult = PalindromeDetector.StringIsPalindrome(input);

        Assert.Equal(expectedResult, actualResult);
    }

    [InlineData("tacocat", true)]
    [InlineData("TACOCAT", true)]
    [InlineData("tAcOCaT", true)]
    [InlineData("I am not a palindrome.", false)]
    [InlineData("t.A1!2@3#4$5%6^7&8*9(0)-_=+;:',<.>/?\"\\|c;OCaT", true)]
    [Theory]
    public void StringIsPalindrome_Passes_ActualPalindromes(string input, bool expectedResult)
    {
        var actualResult = PalindromeDetector.StringIsPalindrome(input);

        Assert.Equal(actualResult, expectedResult);
    }
}