using Xunit;
using MyUtilities;


public class Tests
{

    [Facts]

    public void TestingHere()
    {  
        Assert.Equal(4, MathUtils.Power(2, 2));
        Assert.Equal(5, MathUtils.SquareRoot(25));
        Assert.Equal(5, MathUtils.AbsoluteValue(5));
        Assert.Equal(3, MathUtils.Min(3, 5));
        Assert.Equal(7, MathUtils.Max(7, 4));
        Assert.Equal(4, MathUtils.Add(2, 2));
        Assert.Equal(2, MathUtils.Subtract(4, 2));
        Assert.Equal(8, MathUtils.Divide(64, 8));
        Assert.Equal(6, MathUtils.Multiply(3, 2));
        Assert.Equal(0.69897000433, MathUtils.Log(5));
        Assert.Equal(8, MathUtils.Exp(2, 3));
        Assert.Equal(1, MathUtils.Ceiling(1, 5));
        Assert.Equal(5, MathUtils.Round(2.5, .5));
    }
}
