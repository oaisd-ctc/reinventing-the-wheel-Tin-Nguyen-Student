using Xunit;
using MyUtilities;


public class Tests
{

    [Facts]

    public void TestingHere()
    {

        Assert.Equal(4, MathUtils.Power(2, 2));
    }
}
