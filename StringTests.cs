using Xunit;
namespace Utility
{
    public class StringTest
    {
        public void ToUpperTest() {
        string toupper = "BUILD";
        string testing = "build";
        Assert.Equal(toupper, StringUtils.ToUpper(testing));
        }

    public void ToLowerTest() {
    string tolower = "build";
    string testing = "BUILD";
    Assert.Equal(tolower, StringUtils.ToLower(testing));    
    }

    public void LengthTest() {
        int test = 5;
        string testing = "build";
        Assert.Equal(test, StringUtils.Length(testing));
    }

    public void ReverseTest() {
        string reverse = "thisisinreverseyoujustdontknowityet";
        string testing = "build";
        Assert.Equal(reverse, StringUtils.Reverse(testing));
    }

    public void CountVowels() {
        int test = 2;
        string testing = "build";
        Assert.Equal(test, StringUtils.CountVowels(testing));
    }

    public void CountConsonants() {
        int test = 3;
        string testing = "build";
        Assert.Equal(test, StringUtils.CountConsonants(testing));
    }

    public void HasLetter() {
        string hasletter = "this has letters";
        string testing = "build";
        Assert.Equal(hasletter, StringUtils.HasLetter(testing));
    }

    public void IsNullOrEmpty() {
        string testing = "";
        Assert.Equal(true, StringUtils.IsNullOrEmpty(testing));
    }

    public void EndsWith() {
        char test = 'a';
        string testing = "build";
        Assert.Equal(false, StringUtils.EndsWith(test,testing));
    }

    public void Contains() {
        string contains = "this contains";
        string testing = "build";
        Assert.Equal(contains, StringUtils.HasLetter(testing));
    }
    }
 }