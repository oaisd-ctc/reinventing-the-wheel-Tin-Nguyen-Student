using System;

namespace Utility
{
public class ArrayUtils
{
    static void Main(string[] args)
    {
        int[] test = {5,9,10,36,82,37};
        int[] test2 = {100,90,80,70,60,50,40,30,20,11};
        int pain2 = Average(test);

        Console.WriteLine(pain2);
        //foreach (int p in pain)
        //{
        // Console.Write(p + " ");
       // }
    }

    /// <summary>
    /// Takes in an array of numbers and then averages them out, returning said average
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

    /// <summary>
    /// Takes in an array of numbers and then finds the sum.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sum of the array.
    ///</returns>/// <summary>
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
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sorted ascending array.
    ///</returns>
    public static int[] SortAscending(int[] nums)
    { 
        int temp;

        for (int j = 0; j <= nums.Length - 2; j++) 
        {
            for (int i = 0; i <= nums.Length - 2; i++) 
            {
               if (nums[i] > nums[i + 1]) 
               {
                    temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
               }
            }
         }

         return nums;
    }

    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from smallest to greatest.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sorted ascending array.
    ///</returns>
    public static double[] SortAscending(double[] nums)
    { 
        double temp;

        for (int j = 0; j <= nums.Length - 2; j++) 
        {
            for (int i = 0; i <= nums.Length - 2; i++) 
            {
               if (nums[i] > nums[i + 1]) 
               {
                    temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
               }
            }
         }

         return nums;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from greatest to smallest.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sorted descending array.
    ///</returns>
    public static int[] SortDescending(int[] nums)
    { 
        int temp;

        for (int j = 0; j <= nums.Length - 2; j++) 
        {
            for (int i = 0; i <= nums.Length - 2; i++) 
            {
               if (nums[i] < nums[i + 1]) 
               {
                    temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
               }
            }
         }

         return nums;
    }

    /// <summary>
    /// Takes in an array of numbers and then sorts the numbers from greatest to smallest.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The sorted descending array.
    ///</returns>
    public static double[] SortDescending(double[] nums)
    { 
        double temp;

        for (int j = 0; j <= nums.Length - 2; j++) 
        {
            for (int i = 0; i <= nums.Length - 2; i++) 
            {
               if (nums[i] < nums[i + 1]) 
               {
                    temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
               }
            }
         }

         return nums;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then writes it in reverse.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The reversed array.
    ///</returns>
    public static int[] WriteReverse(int[] nums)
    {
        int[] reversedArray = new int[nums.Length];
        int nums1 = 0;

        for (int i = nums.Length - 1; i >= 0 ; i--)
        {
           reversedArray[nums1] = nums[i];

            nums1++;
        }

        return reversedArray;
    }

    /// <summary>
    /// Takes in an array of numbers and then writes it in reverse.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <returns>
    /// The reversed array.
    ///</returns>
    public static double[] WriteReverse(double[] nums)
    {
        double[] reversedArray = new double[nums.Length];
        int nums1 = 0;

        for (int i = nums.Length - 1; i >= 0 ; i--)
        {
           reversedArray[nums1] = nums[i];

            nums1++;
        }

        return reversedArray;
    }
////////////////////////////////////////////
    /// <summary>
    /// Takes in an array of numbers and then clears a set amount of values.
    ///</summary>
    /// <param name="nums"> An array of numbers you want to input.</param>
    /// <param name="indexStart"> The index of the array (Starts at 0 when counting up from the first number in the array) you want to start clearing from (includes the number it starts at)</param>
    /// <returns>
    /// The reversed array.
    ///</returns>
    public static int[] Clear(int[] nums, int indexStart, int indexEnd)
    {
        for (int i = indexStart; i <= indexEnd; i++)
        {
            nums[i] = 0;
        }

        return nums;
    }

    public static double[] Clear(double[] nums, int indexStart, int indexEnd)
    {
        for (int i = indexStart; i <= indexEnd; i++)
        {
            nums[i] = 0;
        }

        return nums;
    }
////////////////////////////////////////////
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
    public static int[] Copy(int[] nums, int[] copiedArray, int length)
        {
        for (int i = 0; i <= length - 1; i++)
            {
                copiedArray[i] = nums[i];
            }

        return copiedArray;
        }
    }
}