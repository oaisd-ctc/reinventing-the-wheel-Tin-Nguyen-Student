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
    ///<returns>
    /// outputs all lowercase letters to uppercase
    ///</returns>
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
    /// <returns>
    /// the lowercase of all capital letters
    /// </returns>
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
    /// <returns>
    ///The number of amount of characters within the string
    ///</returns>
    public static int Length(string L)
    {
        int incomingStringLength = 0;
        for(int i = 0; i < L.Length; i++){
            incomingStringLength++;
        }
        return incomingStringLength;
    }
    /// <summary>
    /// This method will take in a string and reverse the order of the strings
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    /// <returns>
    ///The string in reverse order
    ///</returns>
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
    /// This method will take in a string and count all of the vowels from the string
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    ///<returns>
    ///Will output the number of vowels within the string
    ///</returns>
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
    /// This method will take in 1 string and it will output the number of consonants in the string
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    ///<returns>
    ///Will output the number of consonants in the string
    ///</returns>
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
    /// This method will take in 1 string and if it has a letter it will output it
    /// <param name="s"> The string you want to turn uppercase</param>
    /// </summary>
    ///<returns>
    ///The letter within the string 
    ///</returns>
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
    public static bool IsNullOrEmpty(string str)
        {
            if (str == null)
            {
                return true;
            }
            else if (str == "")
            {
                return true;
            }
            else if (str == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EndsWith(char value, string str)
        {
            char s = str[str.Length - 1];

            if (s == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Contains(char value, string str)
        {
            int i = 0;
           
            while(i == str.Length - 1)
            {
                if (value != str[i])
                {
                    i++;
                    return false;
                }
                else
                {
                   return true;
                }
            }
        }
}

}

    
