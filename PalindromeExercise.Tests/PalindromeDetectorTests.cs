namespace PalindromeExercise.Tests;

public class PalindromeDetectorTests
{
    [Fact]
    public void StringIsPalindrome_Returns_True_When_Given_Palindrome()
    {
        //Arrange
        PalindromeDetector detector = new PalindromeDetector();
        string inputString = "tacocat";

        //Act
        bool result = detector.StringIsPalindrome(inputString);

        //Assert
        Assert.True(result);
        
    }
}