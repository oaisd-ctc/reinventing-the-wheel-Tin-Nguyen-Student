using System;

namespace Utility
{
public class ArrayUtils
{
    static void Main(string[] args)
    {
       
    }

    /// <summary>
    /// Takes in an array of numbers and then averages them out
    ///</summary>
    /// <param name="nums"> An array of numbers you want to find the collective average of.</param>
    /// <returns>
    /// The result of the formula "sum of numbers / total numbers in the array"
    ///</returns>
    public static double Average(double [] nums)
    {
        double total = 0;
        double average;

        foreach (var n in nums)
        {
            total = total + n;
        }

        average = total / nums.Length;

        return average;
    }

    /// <summary>
    /// Takes in an array of numbers and then averages them out
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The result of the formula "sum of numbers / total numbers in the array"
    ///</returns>
    public static int Average(int [] nums)
    {
        int total = 0;
        int average;

        foreach (var n in nums)
        {
            total = total + n;
        }

        average = total / nums.Length;

        return average;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then finds the maximum number.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The maximum number in the array.
    ///</returns>
    public static int Max(int[] nums)
    {
        int max = nums[0];
        

        foreach(var n in nums){
            if( max < n )
                max = n;
        }

        return max;
    }

    /// <summary>
    /// Takes in an array of numbers and then finds the maximum number.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The maximum number in the array.
    ///</returns>
    public static double Max(double[] nums)
    {
        double max = nums[0];
        

        foreach(var n in nums){
            if( max < n )
                max = n;
        }

        return max;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then finds the minimum number.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The minimum number in the array.
    ///</returns>
    public static int Min(int[] nums)
    {
        int min = nums[0];
        

        foreach(var n in nums){
            if( min > n )
                min = n;
        }

        return min;
    }

    /// <summary>
    /// Takes in an array of numbers and then finds the minimum number.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The minimum number in the array.
    ///</returns>
    public static double Min(double[] nums)
    {
        double min = nums[0];
        

        foreach(var n in nums){
            if( min > n )
                min = n;
        }

        return min;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then finds the sum.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sum of the array.
    ///</returns>
    public static int Sum(int[]nums)
    {
        int sum = 0;

        foreach (var n in nums)
        {
            sum = sum + n;
        }

        return sum;
    }

    ///<summary>
    /// Takes in an array of numbers and then finds the sum.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sum of the array.
    ///</returns>
    public static double Sum(double[]nums)
    {
        double sum = 0;

        foreach (var n in nums)
        {
            sum = sum + n;
        }

        return sum;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then finds the product.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The product of the array.
    ///</returns>
    public static int Product(int[]nums)
    {
        int product = 1;

        foreach (var n in nums)
        {
            product = product * n;
        }

        return product;
    }

    /// <summary>
    /// Takes in an array of numbers and then finds the product.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The product of the array.
    ///</returns>
    public static double Product(double[]nums)
    {
        double product = 1;

        foreach (var n in nums)
        {
            product = product * n;
        }

        return product;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from smallest to greatest.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The sorted ascending array.
    ///</returns>
    public static int[] SortAscending(int[] array)
    { 
        int temp;

        for (int j = 0; j <= array.Length - 2; j++) 
        {
            for (int i = 0; i <= array.Length - 2; i++) 
            {
               if (array[i] > array[i + 1]) 
               {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
               }
            }
         }

         return array;
    }

    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from smallest to greatest.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The sorted ascending array.
    ///</returns>
    public static double[] SortAscending(double[] array)
    { 
        double temp;

        for (int j = 0; j <= array.Length - 2; j++) 
        {
            for (int i = 0; i <= array.Length - 2; i++) 
            {
               if (array[i] > array[i + 1]) 
               {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
               }
            }
         }

         return array;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from greatest to smallest.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The sorted descending array.
    ///</returns>
    public static int[] SortDescending(int[] array)
    { 
        int temp;

        for (int j = 0; j <= array.Length - 2; j++) 
        {
            for (int i = 0; i <= array.Length - 2; i++) 
            {
               if (array[i] < array[i + 1]) 
               {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
               }
            }
         }

         return array;
    }

    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from greatest to smallest.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The sorted descending array.
    ///</returns>
    public static double[] SortDescending(double[] array)
    { 
        double temp;

        for (int j = 0; j <= array.Length - 2; j++) 
        {
            for (int i = 0; i <= array.Length - 2; i++) 
            {
               if (array[i] < array[i + 1]) 
               {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
               }
            }
         }

         return array;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then writes it in reverse.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The reversed array.
    ///</returns>
    public static int[] WriteReverse(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        int nums1 = 0;

        for (int i = array.Length - 1; i >= 0 ; i--)
        {
           reversedArray[nums1] = array[i];

            nums1++;
        }

        return reversedArray;
    }

    /// <summary>
    /// Takes in an array of numbers and then writes it in reverse.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <returns>
    /// The reversed array.
    ///</returns>
    public static double[] WriteReverse(double[] array)
    {
        double[] reversedArray = new double[array.Length];
        int nums1 = 0;

        for (int i = array.Length - 1; i >= 0 ; i--)
        {
           reversedArray[nums1] = array[i];

            nums1++;
        }

        return reversedArray;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then clears a set amount of values.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <param name="indexStart"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to start clearing from (includes the number it starts at)</param>
    /// <param name="indexEnd"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to end clearing from (includes the number it ends at) 
    /// <returns>
    /// The cleared array.
    ///</returns>
    public static int[] Clear(int[] array, int indexStart, int indexEnd)
    {
        for (int i = indexStart; i <= indexEnd; i++)
        {
            array[i] = 0;
        }

        return array;
    }

    /// <summary>
    /// Takes in an array of numbers and then clears a set amount of values.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <param name="indexStart"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to start clearing from (includes the number it starts at)</param>
    /// <param name="indexEnd"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to end clearing from (includes the number it ends at) 
    /// <returns>
    /// The cleared array.
    ///</returns>
    public static double[] Clear(double[] array, int indexStart, int indexEnd)
    {
        for (int i = indexStart; i <= indexEnd; i++)
        {
            array[i] = 0;
        }

        return array;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then resizes the array to a given index .
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <param name="newSize"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to resize the array to.</param>
    /// <returns>
    /// The resized array.
    ///</returns>
    public static int[] Resize(int [] array, int newSize)
    {
        int[] resizedArray = new int[newSize];

        for (int i = 0; i < newSize; i++)
        {

            if(i > array.Length - 1)
            {
                resizedArray[i] = 0;
            }
            else
            {
                resizedArray[i] = array[i];
            }
        }
        return resizedArray;
    }

    /// <summary>
    /// Takes in an array of numbers and then resizes the array to a given index.
    ///</summary>
    /// <param name="array"> An array you want to input.</param>
    /// <param name="newSize"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to resize the array to.</param>
    /// <returns>
    /// The resized array.
    ///</returns>
    public static double[] Resize(double [] array, int newSize)
    {
        double[] resizedArray = new double[newSize];

        for (int i = 0; i < newSize; i++)
        {

            if(i > array.Length - 1)
            {
                resizedArray[i] = 0;
            }
            else
            {
                resizedArray[i] = array[i];
            }
        }
        return resizedArray;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then copied values to a given index.
    ///</summary>
    /// <param name="array"> An array you want to input to be copied from.</param>
    /// <param name="copiedArray"> An array you want to input to be copied to. </param>
    /// <param name="length"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to copy to another array (starts copying from index 0 and includes indexed number).</param>
    /// <returns>
    /// The copied array.
    ///</returns>
    public static int[] Copy(int[] array, int[] copiedArray, int length)
        {
        for (int i = 0; i <= length - 1; i++)
            {
                copiedArray[i] = array[i];
            }

        return copiedArray;
        }

        /// <summary>
        /// Takes in an array of numbers and then copied values to a given index.
        ///</summary>
        /// <param name="array"> An array you want to input to be copied from.</param>
        /// <param name="copiedArray"> An array you want to input to be copied to. </param>
        /// <param name="length"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to copy to another array (starts copying from index 0 and includes indexed number).</param>
        /// <returns>
        /// The copied array.
        ///</returns>
        public static double[] Copy(double[] array, double[] copiedArray, int length)
        {
        for (int i = 0; i <= length - 1; i++)
            {
                copiedArray[i] = array[i];
            }

        return copiedArray;
        }
    }
}