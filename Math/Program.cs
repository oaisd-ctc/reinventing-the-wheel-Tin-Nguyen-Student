
namespace MyUtilities

{
public class Math
{

        public static void MathUtils(string[] args)
        {
                
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
        
         public static int AbsoluteValue(int x)
        {
                return x * ((v>0)) - ((v<0));
        }
        public static double AbsoluteValue(int x)
        {
                return x * ((v>0)) - ((v<0));
        }
        public static float AbsoluteValue(int x)
        {
                return x * ((v>0)) - ((v<0));
        }
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
         public static int Add(int x, int y)
        {
                
                {
                      int result = x + y;
                      return result;
                }
                
        }
         public static double Add(double x, double y)
        {
                
                {
                      double result = x + y;
                      return result;
                }
                
        }
         public static float Add(float x, float y)
        {
                
                {
                      float result = x + y;
                      return result;
                }
                
        }

         public static int Subtract(int x, int y)
        {
                
                {
                        int result = x - y;
                        return result;
                }
        }
         public static double Subtract(double x, double y)
        {
                
                {
                        double result = x - y;
                        return result;
                }
        }

         public static float Subtract(float x, float y)
        {
                
                {
                        float result = x - y;
                        return result;
                }
        }

         public static int Divide(int x, int y)
        {
                
                {
                        int answer = x / y;
                        return result;
                }
        }
         public static double Divide(double x, double y)
        {
                
                {
                        double answer = x / y;
                        return result;
                }
        }
         public static float Divide(float x, float y)
        {
                
                {
                        float answer = x / y;
                        return result;
                }
        }

         public static int Multiply(int x, int y)
        {
                
                {
                        int result = x * y;
                        return result;
                }
        }
         public static double Multiply(double x, double y)
        {
                
                {
                        double result = x * y;
                        return result;
                }
        }
         public static float Multiply(float x, float y)
        {
                
                {
                        float result = x * y;
                        return result;
                }
        }

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

         public static double Exp(double x, double y)
        {
                double i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
        public static decimal Exp(decimal x, decimal y)
        {
                decimal i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
        public static float Exp(float x, float y)
        {
                float i =  2.71828;
                for(i = 1; 1 <= y; ++i)
                {
                i = i * y;
                }
                return i;
                
        }
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

         public static double Round(double x)
        {
                double a = 2.5;
                sum = (double) (a + 0.5);
                return sum;
        }
        
         public static decimal Round(decimal x)
        {
                decimal a = 2.5;
                sum = (decimal) (a + 0.5);
                return sum;
        }
        
         public static float Round(float x)
        {
                float a = 2.5;
                sum = (float) (a + 0.5);
                return sum;
        }
    }
}
