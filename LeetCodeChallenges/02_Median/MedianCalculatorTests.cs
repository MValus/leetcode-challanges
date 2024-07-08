using Xunit;

namespace LeetCodeChallenges._02_Median;

public class MedianCalculatorTests
{
    [Theory]
    [InlineData(2.0, new sbyte[] { 1, 3 }, new sbyte[] { 2 })]
    [InlineData(2.5, new sbyte[] { 1, 2 }, new sbyte[] { 3, 4 })]
    public void MedianTests(double expectedMedian, sbyte[] nums1, sbyte[] nums2)
    {
        Assert.Equal(expectedMedian, MedianCalculator.Median(nums1, nums2));
    }
}