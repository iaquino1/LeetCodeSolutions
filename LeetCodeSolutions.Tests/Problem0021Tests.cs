using LeetCodeSolutions.Problems.Problem0021_MergeTwoSortedLists;
using LeetCodeSolutions.Shared;
using NUnit.Framework;

namespace LeetCodeSolutions.Tests;

[TestFixture]
public class Problem0021Tests
{
    private static IEnumerable<TestCaseData> MergeTwoSortedListsTestCases
    {
        get
        {
            yield return new TestCaseData(
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4)))))));
            yield return new TestCaseData(
                null,
                null,
                null);
            yield return new TestCaseData(
                null,
                new ListNode(0),
                new ListNode(0));
        }
    }

    [Test, TestCaseSource(nameof(MergeTwoSortedListsTestCases))]
    public void MergeTwoLists_ShouldReturnExpectedResult(ListNode list1, ListNode list2, ListNode expected)
    {
        // Act
        ListNode result = Problem0021_MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        //Assert.That(result, Is.EqualTo(expected));
        Assert.That(AreListsEqual(result, expected));
    }

    private static bool AreListsEqual(ListNode a, ListNode b)
    {
        while (a != null && b != null)
        {
            if (a.val != b.val) return false;
            a = a.next;
            b = b.next;
        }

        return a == null && b == null;
    }
}
