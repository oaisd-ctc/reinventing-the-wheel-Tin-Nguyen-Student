using Xunit;
using MyUtilities;


public class Tests
{

    [Facts]
    public void PowerTesting()
    {
        Assert.Equal(4, MathUtils.Power(2, 2));
    }
    [Facts]
    public void SquareRootTesting()
    {
        Assert.Equal(5, MathUtils.SquareRoot(25));
    }
    [Facts]
    public void AbsoluteValueTest()
    {
        Assert.Equal(5, MathUtils.AbsoluteValue(5));
    }
    [Facts]
    public void MinTest()
    {
        Assert.Equal(3, MathUtils.Min(3, 5));
    }
    [Facts]
    public void MaxTest()
    {
        Assert.Equal(7, MathUtils.Max(7, 4));
    }
    [Facts]
    public void AddTest()
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }
    [Facts]
    public void SubtractTest()
    {
        Assert.Equal(2, MathUtils.Subtract(4, 2));
    }
    [Facts]
    public void DivideTest()
    {
        Assert.Equal(8, MathUtils.Divide(64, 8));
    }
    [Facts]
    public void MultiplyTest()
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }
    [Facts]
    public void LogTest()
    {
        Assert.Equal(0.69897000433, MathUtils.Log(5));
    }
    [Facts]
    public void ExponentTest()
    {
        Assert.Equal(8, MathUtils.Exp(2, 3));
    }
    [Facts]
    public void CeilingTest()
    {
        Assert.Equal(7, MathUtils.Ceiling(6.2));
    }
    [Facts]
    public void RoundTest()
    {
        Assert.Equal(3, MathUtils.Round(2.5, .5));
    }
}
