
namespace MyUtilities

{
public class Math
{

        public static void MathUtils(string[] args)
        {
                Assert.Equal(4, MathUtils.Add(2, 2));
        }
        ///<summary>
        ///Takes a number (x) and then multiplies it by the power (y)
        ///</summary>
        ///<param name = "x">The Base Number.</param>
        ///<param name = "y">The power of the base number.</param>
        ///<returns>
        ///Gives product between the base number (x) and the power (y),
        ///</returns>

         public static int Power(int x, int y)
        {
                
                
                {
                        int power = 1;
                        for(i = 1; 1 <= y; ++i)
                        {
                                power = power * x;
                        }
                        return power;
                }
        }
        ///<summary>
        ///Takes a number (x) and then multiplies it by the power (y)
        ///</summary>
        ///<param name = "x">The Base Number.</param>
        ///<param name = "y">The power of the base number.</param>
        ///<returns>
        ///Gives product between the base number (x) and the power (y),
        ///</returns>
         public static double Power(double x, double y)
        {
                
        
                {
                        double power = 1;
                        for(i = 1; 1 <= y; ++i)
                        {
                                power = power * x;
                        }
                        return power;
                }
        }
        ///<summary>
        ///Takes a number (x) and then multiplies it by the power (y)
        ///</summary>
        ///<param name = "x">The Base Number.</param>
        ///<param name = "y">The power of the base number.</param>
        ///<returns>
        ///Gives product between the base number (x) and the power (y),
        ///</returns>
         public static float Power(float x, float y)
        {
                
                
                {
                        float power = 1;
                        for(i = 1; 1 <= y; ++i)
                        {
                                power = power * x;
                        }
                        return power;
                }
        }
        ///<summary>
        ///Takes 
        public static double SquareRoot(int x)
        {
                int i = 0;
                double root = 1;
                while(true)
                {
                        i = i + 1;
                        root = (number / root + root) / 2;
                        if(i == number + 1) {break;}
                        return root;
                }
        }
        public static float SquareRoot(int x)
        {
                int i = 0;
                float root = 1;
                while(true)
                {
                        i = i + 1;
                        root = (number / root + root) / 2;
                        if(i == number + 1) {break;}
                        return root;
                }
        }
        public static decimal SquareRoot(int x)
         {
                int i = 0;
                decimal root = 1;
                while(true)
                {
                        i = i + 1;
                        root = (number / root + root) / 2;
                        if(i == number + 1) {break;}
                        return root;
                }

        }
        ///<summary>
        ///Takes the x and when x is greater than 0 it subtracts it by x when it is less than 0 which in turn always makes x a positive
        ///</summary>
        ///param name = "x">The Base Number.</param>
        ///<returns>
        ///Gives a positive number of x
        ///</returns>
         public static int AbsoluteValue(int x)
        {
                return x * ((x>0)) - ((x<0));
        }
        ///<summary>
        ///Takes the x and when x is greater than 0 it subtracts it by x when it is less than 0 which in turn always makes x a positive
        ///</summary>
        ///param name = "x">The Base Number.</param>
        ///<returns>
        ///Gives a positive number of x
        ///</returns>
        public static double AbsoluteValue(int x)
        {
                return x * ((x>0)) - ((x<0));
        }
        ///<summary>
        ///Takes the x and when x is greater than 0 it subtracts it by x when it is less than 0 which in turn always makes x a positive
        ///</summary>
        ///param name = "x">The Base Number.</param>
        ///<returns>
        ///Gives a positive number of x
        ///</returns>
        public static float AbsoluteValue(int x)
        {
                return x * ((x>0)) - ((x<0));
        }
        ///<summary>
        ///Takes both int x and y and outputs the minimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the minium number between x and y
        ///</returns>

         public static bool Min(float x, float y)
        {
                {
                        if (x < y)
                        {
                                
                                return x;
                        }
                        else if (x == y)
                        {
                                
                                return x;
                        }
                        else
                        {
                                
                                return y;
                        }
                }
        }
        ///<summary>
        ///Takes both int x and y and outputs the minimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the minium number between x and y
        ///</returns>
        public static bool Min(int x, int y)
        {
                {
                        if (x < y)
                        {
                                return x;
                                
                        }
                        else if (x == y)
                        {
                                return x;
                                
                        }
                        else
                        {
                                
                                return y;
                        }
                }
        }
        ///<summary>
        ///Takes both int x and y and outputs the minimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the minium number between x and y
        ///</returns>
        public static bool Min(double x, double y)
        {
                {
                        if (x < y)
                        {
                                return x;
                        }
                        else if (x == y)
                        {
                                return x;
                        }
                        else
                        {
                                return y;
                        }
                }
        }
        ///<summary>
        ///Takes both int x and y and outputs the maxmimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the maxmimum number between x and y
        ///</returns>
         public static  bool Max(int x, int y)
        {
                if (x > y)
                {
                        return x;
                }
                else if (x == y)
                {
                        return;
                }
                else 
                {
                        return y;
                }
        }
        ///<summary>
        ///Takes both int x and y and outputs the maxmimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the maxmimum number between x and y
        ///</returns>
        public static  bool Max(float x, float y)
        {
                if (x > y)
                {
                        return x;
                }
                else if (x == y)
                {
                        return;
                }
                else 
                {
                        return y;
                }
        }
        ///<summary>
        ///Takes both int x and y and outputs the maxmimum number out of the 2
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the maxmimum number between x and y
        ///</returns>
        public static  bool Max(double x, double y)
        {
                if (x > y)
                {
                        return x;
                }
                else if (x == y)
                {
                        return;
                }
                else 
                {
                        return y;
                }
        }
        ///<summary>
        ///Takes both int x and y and adds them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the sum of x and y
        ///</returns>
         public static int Add(int x, int y)
        {
                
                {
                      int result = x + y;
                      return result;
                }
                
        }
        ///<summary>
        ///Takes both int x and y and adds them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the sum of x and y
        ///</returns>
         public static double Add(double x, double y)
        {
                
                {
                      double result = x + y;
                      return result;
                }
                
        }
        ///<summary>
        ///Takes both int x and y and adds them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the sum of x and y
        ///</returns>
         public static float Add(float x, float y)
        {
                
                {
                      float result = x + y;
                      return result;
                }
                
        }
        ///<summary>
        ///Takes both int x and y and subtracts them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the difference of x and y
        ///</returns>
         public static int Subtract(int x, int y)
        {
                
                {
                        int result = x - y;
                        return result;
                }
        }
         ///<summary>
        ///Takes both int x and y and subtracts them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the difference of x and y
        ///</returns>
         public static double Subtract(double x, double y)
        {
                
                {
                        double result = x - y;
                        return result;
                }
        }
         ///<summary>
        ///Takes both int x and y and subtracts them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the difference of x and y
        ///</returns>

         public static float Subtract(float x, float y)
        {
                
                {
                        float result = x - y;
                        return result;
                }
        }
         ///<summary>
        ///Takes both int x and y and divides them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the quotient of x and y
        ///</returns>

         public static int Divide(int x, int y)
        {
                
                {
                        int answer = x / y;
                        return result;
                }
        }
        ///<summary>
        ///Takes both int x and y and divides them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the quotient of x and y
        ///</returns>
         public static double Divide(double x, double y)
        {
                
                {
                        double answer = x / y;
                        return result;
                }
        }
        ///<summary>
        ///Takes both int x and y and divides them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the quotient of x and y
        ///</returns>
         public static float Divide(float x, float y)
        {
                
                {
                        float answer = x / y;
                        return result;
                }
        }
        ///<summary>
        ///Takes both int x and y and multiplies them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the product of x and y
        ///</returns>
         public static int Multiply(int x, int y)
        {
                
                {
                        int result = x * y;
                        return result;
                }
        }
         ///<summary>
        ///Takes both int x and y and multiplies them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the product of x and y
        ///</returns>
         public static double Multiply(double x, double y)
        {
                
                {
                        double result = x * y;
                        return result;
                }
        }
         ///<summary>
        ///Takes both int x and y and multiplies them together 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the product of x and y
        ///</returns>
         public static float Multiply(float x, float y)
        {
                
                {
                        float result = x * y;
                        return result;
                }
        }
         ///<summary>
        ///Takes x and when log is greater than or equal to 0, 
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns the product of x and y
        ///</returns>
         public static double Log(double x)
        {
                double log = 25;
                while (log => 0)
                {
                        double num = (1 << log);
                        if ((num & x) != 0)
                        return (double) log;
                        log --;

                }
                return -1;
        }
         public static int Log(int x)
        {
                 int log = 25;
                while (log => 0)
                {
                        int num = (1 << log);
                        if ((num & x) != 0)
                        return (int) log;
                        log --;

                }
                return -1;
        }
         public static decimal Log(decimal x)
        {
                 decimal log = 25;
                while (log => 0)
                {
                        decimal num = (1 << log);
                        if ((num & x) != 0)
                        return (decimal) log;
                        log --;

                }
                return -1;
        }
        ///<summary>
        ///Takes i and when i = 1 and 1 is less than or equal to y, the i will multiply with the y as an exponent
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns i after it multiplys by the exponent of y
        ///</returns>
         public static double Exp(double x, double y)
        {
                double i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
        ///<summary>
        ///Takes i and when i = 1 and 1 is less than or equal to y, the i will multiply with the y as an exponent
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns i after it multiplys by the exponent of y
        ///</returns>
        public static decimal Exp(decimal x, decimal y)
        {
                decimal i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
        ///<summary>
        ///Takes i and when i = 1 and 1 is less than or equal to y, the i will multiply with the y as an exponent
        ///</summary>
        ///<param name = "x">1st Number.</param>
        ///<param name = "y">2nd Number.</param>
        ///<returns>
        ///Returns i after it multiplys by the exponent of y
        ///</returns>
        public static float Exp(float x, float y)
        {
                float i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
        ///summary
        ///Takes the a and b to find the smallest integer 
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<param name = "y">2nd number.</param>
        ///<returns>
        ///Returns the smallest integer of num
        ///</returns>
         public static double Ceiling(double x, double y)
        {
                double a = 3;
                double b = 4; num = 0;
                if ((a % b) != 0)
                {
                        num = (a / b) + (a % b);
                        return num;
                }
                else
                {
                        num = (a / b);
                        return num;
                }
        }
        ///summary
        ///Takes the a and b to find the smallest integer 
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<param name = "y">2nd number.</param>
        ///<returns>
        ///Returns the smallest integer of num
        ///</returns>
        public static decimal Ceiling(decimal x, decimal y)
        {
                decimal a = 3;
                decimal b = 4; num = 0;
                if ((a % b) != 0)
                {
                        num = (a / b) + (a % b);
                        return num;
                }
                else
                {
                        num = (a / b);
                        return num;
                }
        }
        ///summary
        ///Takes the a and b to find the smallest integer 
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<param name = "y">2nd number.</param>
        ///<returns>
        ///Returns the smallest integer of num
        ///</returns>
        public static float Ceiling(float x, float y)
        {
                float a = 3;
                float b = 4; num = 0;
                if ((a % b) != 0)
                {
                        num = (a / b) + (a % b);
                        return num;
                }
                else
                {
                        num = (a / b);
                        return num;
                }
        }
        ///summary
        ///Takes the a variable and adds it by .5 to get a whole number
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
         public static double Round(double x)
        {
                double a = 2.5;
                sum = (double) (a + 0.5);
                return sum;
        }
        ///summary
        ///Takes the a variable and adds it by .5 to get a whole number
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
         public static decimal Round(decimal x)
        {
                decimal a = 2.5;
                sum = (decimal) (a + 0.5);
                return sum;
        }
        ///summary
        ///Takes the a variable and adds it by .5 to get a whole number
        ///</summary>
        ///<param name = "x">1st numner.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
         public static float Round(float x)
        {
                float a = 2.5;
                sum = (float) (a + 0.5);
                return sum;
        }
    }
}
