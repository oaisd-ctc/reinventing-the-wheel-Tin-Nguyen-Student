
namespace MyUtilities

{
public class Math
{

        public static void MathUtils(string[] args)
        {
                
                MathUtils.Power(2,2);
        }
        
         public static double Power(double x, double y)
        {
                
                for (int x = 0; x <= 50; x++)
                {
                        int answer = MathUtils.Power(x, y);
                        Console.WriteLine(answer);
                        return;
                        
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
         public static bool Min(int x, int y)
        {
                foreach (int n in nums)
                {
                        if (x < y)
                        {
                                Console.WriteLine(x);
                                return;
                        }
                        else if (x == y)
                        {
                                Console.WriteLine("The are the same values");
                                return;
                        }
                        else
                        {
                                Console.WriteLine(y);
                                return;
                        }
                }
        }
         public static  bool Max(int x, int y)
        {
                foreach (int n in nums);
                if (x > y)
                {
                        Console.WriteLine(x);
                        return;
                }
                else if (x == y)
                {
                        Console.WriteLine(y);
                return;
                }
                else 
                {
                        Console.WriteLine(y);
                        return;
                }
        }
         public static int Add(int x, int y)
        {
                foreach (int i in x)
                {
                      int result = x + y;
                      return result;
                }
                
        }
         public static double Add(double x, double y)
        {
                foreach (double i in x)
                {
                      double result = x + y;
                      return result;
                }
                
        }
         public static float Add(float x, float y)
        {
                foreach (float i in x)
                {
                      float result = x + y;
                      return result;
                }
                
        }

         public static int Subtract(int x, int y)
        {
                foreach (int i in x)
                {
                        int result = x - y;
                        return result;
                }
        }
         public static double Subtract(double x, double y)
        {
                foreach (double i in x)
                {
                        double result = x - y;
                        return result;
                }
        }

         public static float Subtract(float x, float y)
        {
                foreach (float i in x)
                {
                        float result = x - y;
                        return result;
                }
        }

         public static int Divide(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer = x / y;
                        return result;
                }
        }
         public static double Divide(double x, double y)
        {
                foreach (double i in x)
                {
                        double answer = x / y;
                        return result;
                }
        }
         public static float Divide(float x, float y)
        {
                foreach (float i in x)
                {
                        float answer = x / y;
                        return result;
                }
        }

         public static int Multiply(int x, int y)
        {
                foreach (int i in x)
                {
                        int result = x * y;
                        return result;
                }
        }
         public static double Multiply(double x, double y)
        {
                foreach (double i in x)
                {
                        double result = x * y;
                        return result;
                }
        }
         public static float Multiply(float x, float y)
        {
                foreach (float i in x)
                {
                        float result = x * y;
                        return result;
                }
        }

         public static double Log(int x)
        {
                
                double answer = Math.Log();
                Console.WriteLine(answer);
                return;
        }

         public static int Exponent(int x, int y)
        {
                int answer = Math.Exponent(x, y);
                Console.WriteLine(answer);
                return;
        }

         public static double Remainder(int x, int y)
        {
                double answer = x / y;
                double remainder = Math.Remainder(answer);
                Console.WriteLine(remainder);
                return;
        }

         public static double Round(int x)
        {
                double answer = Math.Round(x);
                Console.Writeline(answer);
                return;
        }
    }
}
