using Xunit;
using Utility;

public class Tests
{
    [Fact]
    public void AverageTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int desiredOutcome = 11;
        Assert.Equal(desiredOutcome, ArrayUtils.Average(testArray));
    }

    [Fact]
    public void MaxTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int desiredOutcome = 21;
        Assert.Equal(desiredOutcome, ArrayUtils.Max(testArray));
    }

    [Fact]
    public void MinTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int desiredOutcome = 5;
        Assert.Equal(desiredOutcome, ArrayUtils.Min(testArray));
    }

    [Fact]
    public void SortAscendingTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] desiredOutcome = {5,8,9,10,17,21};
        Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(testArray));
    }

    [Fact]
    public void SortDescendingTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] desiredOutcome = {21,17,10,9,8,5};
        Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(testArray));
    }

    [Fact]
    public void SumTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int desiredOutcome = 70;
        Assert.Equal(desiredOutcome, ArrayUtils.Sum(testArray));
    }
}
