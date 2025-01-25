using LeetCodeSolutions.Problems.Problem0014_LongestCommonPrefix;
using NUnit.Framework;

namespace LeetCodeSolutions.Tests;

[TestFixture]
public class Problem0014Tests
{
    [Test]
    public void LongestCommonPrefix_ShouldReturnCorrectPrefix_WhenInputIsValid()
    {
        // Arrange
        string[] input = { "flower", "flow", "flight" };
        string expected = "fl";

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldReturnEmptyString_WhenNoCommonPrefix()
    {
        // Arrange
        string[] input = { "dog", "racecar", "car" };
        string expected = string.Empty;

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldReturnFullString_WhenOnlyOneStringInArray()
    {
        // Arrange
        string[] input = { "single" };
        string expected = "single";

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldHandleEmptyStringsCorrectly()
    {
        // Arrange
        string[] input = { "", "b", "c" };
        string expected = string.Empty;

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldHandleEmptyArrayCorrectly()
    {
        // Arrange
        string[] input = { };
        string expected = string.Empty;

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldReturnEmpty_WhenAllStringsAreEmpty()
    {
        // Arrange
        string[] input = { "", "", "" };
        string expected = string.Empty;

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LongestCommonPrefix_ShouldHandleNullInputCorrectly()
    {
        // Arrange
        string[] input = null;
        string expected = string.Empty;

        // Act
        string result = Problem0014_LongestCommonPrefix.LongestCommonPrefix(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
