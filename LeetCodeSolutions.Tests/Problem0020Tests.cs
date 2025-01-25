using LeetCodeSolutions.Problems.Problem0020_ValidParentheses;
using NUnit.Framework;

namespace LeetCodeSolutions.Tests;

[TestFixture]
public class Problem0020Tests
{
    private static IEnumerable<TestCaseData> ValidParenthesesTestCases
    {
        get
        {
            yield return new TestCaseData("()", true);
            yield return new TestCaseData("()[]{}", true);
            yield return new TestCaseData("(]", false);
            yield return new TestCaseData("([)]", false);
            yield return new TestCaseData("{[]}", true);
        }
    }

    [Test, TestCaseSource(nameof(ValidParenthesesTestCases))]
    public void IsValidParentheses_ShouldReturnExpectedResult(string input, bool expected)
    {
        // Act
        bool result = Problem0020_ValidParentheses.IsValid(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
