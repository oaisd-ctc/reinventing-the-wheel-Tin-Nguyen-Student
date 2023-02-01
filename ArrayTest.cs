using Xunit;
using Utility;

public class Tests
{

    /// <summary>
    ///
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

    [Fact]
    public void ProductTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int desiredOutcome = 1285200;
        Assert.Equal(desiredOutcome, ArrayUtils.Product(testArray));
    }

    [Fact]
    public void WriteReverseTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] desiredOutcome = {8,21,17,10,5,9};
        Assert.Equal(desiredOutcome, ArrayUtils.WriteReverse(testArray));
    }

    [Fact]
    public void ClearTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] desiredOutcome = {9,5,0,0,0,0};
        Assert.Equal(desiredOutcome, ArrayUtils.Clear(testArray,2,5));
    }

    [Fact]
    public void ResizeTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] desiredOutcome = {9,5,10};
        Assert.Equal(desiredOutcome, ArrayUtils.Resize(testArray,3));
    }

    [Fact]
    public void CopyTest()
    {
        int[] testArray = {9,5,10,17,21,8};
        int[] testArray2 = {0,0,0,0,10,9};
        int[] desiredOutcome = {9,5,10,17,10,9};
        Assert.Equal(desiredOutcome, ArrayUtils.Copy(testArray,testArray2,4));
    }
}
