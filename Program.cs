using Xunit;

namespace Utility
{
    

public class Tests
{

    [Fact]
    public void PowerTesting()
    {
        Assert.Equal(4, MathUtils.Power(2, 2));
    }
    [Fact]
    public void SquareRootTesting()
    {
        Assert.Equal(5, MathUtils.SquareRoot(25));
    }
    [Fact]
    public void AbsoluteValueTest()
    {
        Assert.Equal(5, MathUtils.AbsoluteValue(5));
    }
    [Fact]
    public void MinTest()
    {
        Assert.Equal(3, MathUtils.Min(3, 5));
    }
    [Fact]
    public void MaxTest()
    {
        Assert.Equal(7, MathUtils.Max(7, 4));
    }
    [Fact]
    public void AddTest()
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }
    [Fact]
    public void SubtractTest()
    {
        Assert.Equal(2, MathUtils.Subtract(4, 2));
    }
    [Fact]
    public void DivideTest()
    {
        Assert.Equal(8, MathUtils.Divide(64, 8));
    }
    [Fact]
    public void MultiplyTest()
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }
    [Fact]
    public void PercentTest()
    {
        Assert.Equal(5, MathUtils.Percent(.05));
    }
    [Fact]
    public void ExponentTest()
    {
        Assert.Equal(8, MathUtils.Exp(2, 3));
    }
    [Fact]
    public void CeilingTest()
    {
        Assert.Equal(7, MathUtils.Ceiling(6.2));
    }
    [Fact]
    public void RoundTest()
    {
        Assert.Equal(3, MathUtils.Round(2.5, .5));
    }
}
}