using System;
public static class Array
{
    static void Main(string[] args)
    {
        int[] test = {9,7,1,2,3};
        int[] pain = Resize(test, 19);

        foreach (int p in pain)
        {
         Console.Write(p + " ");
        }
    }

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
    public static int Max(int[] nums)
    {
        int max = nums[0];
        

        foreach(var n in nums){
            if( max < n )
                max = n;
        }

        return max;
    }

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
    public static int Min(int[] nums)
    {
        int min = nums[0];
        

        foreach(var n in nums){
            if( min > n )
                min = n;
        }

        return min;
    }

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
    public static int Sum(int[]nums)
    {
        int sum = 0;

        foreach (var n in nums)
        {
            sum = sum + n;
        }

        return sum;
    }

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
    public static int Product(int[]nums)
    {
        int product = 1;

        foreach (var n in nums)
        {
            product = product * n;
        }

        return product;
    }

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
    public static int[] Clear(int[] nums, int index, int length)
    {
        for (int i = index; i <= length - 1; i++)
        {
            nums[i] = 0;
        }

        return nums;
    }

    public static double[] Clear(double[] nums, int index, int length)
    {
        for (int i = index; i <= length - 1; i++)
        {
            nums[i] = 0;
        }

        return nums;
    }

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
}
