public static class Array
{
    static void Main(string[] args)
    {

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
        int product = 0;

        foreach (var n in nums)
        {
            product = product * n;
        }

        return product;
    }

    public static double Product(double[]nums)
    {
        double product = 0;

        foreach (var n in nums)
        {
            product = product * n;
        }

        return product;
    }
////////////////////////////////////////////
    public static int SortAscending(int[] nums)
    {
        int x = ;
        int numsLength = nums.Length;
        int[] sortedArray = new int[nums.Length];
        int min = nums[0];
        
        foreach(var n in nums){
            if( min > n )
                min = n;
        sortedArray[nums.Length]
        }

        Console.WriteLine(sortedArray);
    }
}
