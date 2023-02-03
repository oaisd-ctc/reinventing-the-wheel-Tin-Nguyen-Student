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
        string length = "thisislengthyintentionally";
        string testing = "build";
        Assert.Equal(length, StringUtils.Length(testing));
    }

    public void ReverseTest() {
        string reverse = "thisisinreverseyoujustdontknowityet";
        string testing = "build";
        Assert.Equal(reverse, StringUtils.Reverse(testing));
    }

    public void CountVowels() {
        string countvowels = "aeiou however";
        string testing = "build";
        Assert.Equal(countvowels, StringUtils.CountVowels(testing));
    }

    public void CountConsonants() {
        string countconsonants = "i forgot how this one worjs";
        string testing = "build";
        Assert.Equal(countconsonants, StringUtils.CountConsonants(testing));
    }

    public void HasLetter() {
        string hasletter = "this has letters";
        string testing = "build";
        Assert.Equal(hasletter, StringUtils.HasLetter(testing));
    }

    public void IsNullOrEmpty() {
        string isnullorempty = "this is null or empty";
        string testing = "build";
        Assert.Equal(isnullorempty, StringUtils.HasLetter(testing));
    }

    public void EndsWith() {
        string endswith = "this ends with";
        string testing = "build";
        Assert.Equal(endswith, StringUtils.HasLetter(testing));
    }

    public void Contains() {
        string contains = "this contains";
        string testing = "build";
        Assert.Equal(contains, StringUtils.HasLetter(testing));
    }
    }
 }