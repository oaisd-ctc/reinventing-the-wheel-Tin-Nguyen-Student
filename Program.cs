public class StringUtils
{
    static void Main(string[] args)
    {
      string testString = "hello";
      string upperTestString = StringUtils.ToUpper("hello");

      // upperTestString should be "HELLO"
    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static string ToUpper(string s)
    {
        return s.ToUpper();
    }
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the arguments lowercase form.
    /// <param name="s"> The string you want to turn lowercase</param>
    /// </summary>
    public static string ToLower(string TL)
    {
        
    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a number that represents the amount of characters in the string parameter
    /// <param name="L"> The string you want to tell you the length of your input</param>
    /// </summary>
    public static int Length(string L)
    {
        int incomingStringLength = 0;

        for(int i = 0; i < L.Length; i++){
            incomingStringLength++;
        }

        return incomingStringLength;
    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static string Reverse(string R)
    {

    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static int CountVowels(string CV)
    {

    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static int CountConsonants(string CC)
    {

    }

    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static bool HasLetter(string HL, char I)
    {

    }

}

