using System;
namespace Utility
{

public class StringUtils
{
    static void Main(string[] args)
    {
      
    }
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form.
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static string ToUpper(string s)
    {
        String answer ="";
    for(int i = 0; i < s.Length; i++)
    {
        if(s[i] >= 'a' && s[i] <= 'z')
        {
            answer+=(char)(s[i] - 'a' + 'A');
        }
        else
        {
            answer += s[i];
        }
    }
        return answer;
    }
    
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the arguments lowercase form.
    /// <param name="s"> The string you want to turn lowercase</param>
    /// </summary>
    public static string ToLower(string s)
    {
        String answer ="";
    for(int i = 0; i < s.Length; i++)
    {
        if(s[i] >= 'A' && s[i] <= 'Z')
        {
            answer+=(char)(s[i] - 'A' + 'a');
        }
        else
        {
            answer += s[i];
        }
        
    }
    return answer;
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
    public static string Reverse(string s)
    {
        char[] stringArray = s.ToCharArray();
        string reverse = String.Empty;
        for (int i = stringArray.Length - 1; i >= 0; i--)
        {
            reverse += stringArray[i];
        }
        return reverse;
    }
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form.
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static int CountVowels(string s)
    {
        int i           = 0;
        int countVowels = 0;

        for (i = 0; i<s.Length; i++)
        {
            if ((s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') ||
                (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U'))
                countVowels++;
        }
        return countVowels;
    }
    
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form.
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static int CountConsonants(string s)
    {
        int i = 0;
        int vowels = 0;
        int consonants = 0;
        int p = s.Length; 

        for(i = 0; i < p; p++)
        {
            if(s[i] == 'a' || s[i] == 'e' ||
            s[i] == 'i' || s[i] == 'o' ||
            s[i] == 'u' || s[i] == 'A' ||
            s[i] == 'E' || s[i] == 'I' ||
            s[i] == 'O' || s[i] == 'U')
            {
                vowels++;
                return vowels;
            }
            else if 
            ((s[i] >= 'a' && s[i] <= 'z') ||
            (s[i] >= 'A' && s[i] <= 'Z'))
            {
                consonants++;
                
            }
            
        }
        return consonants;

    }
    /// <summary>
    /// This method will take in 1 string as a parameter and return a string in the argument's uppercase form.
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    public static bool HasLetter(string s, string g)
    {
        int p = s.Length;
        int l = g.Length;
        int pp = 0;
        for(int i = 0; i < 1; i++)
        {
            if (s[i] == g[0])
            {
                for(int a = i + 1, n =1; n < a; n++, a++)
                {
                    if (s[a] == g[n])
                    {
                        pp++;
                    }
                }
            }
        }
        if (pp == l-1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}
