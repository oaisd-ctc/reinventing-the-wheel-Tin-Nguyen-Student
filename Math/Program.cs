
namespace MyUtilities

{
public class Math
{

        public static void MathUtils(string[] args)
        {
                MathUtils.Power(6,5);
        }
        
         public static double Power(double x, double y)
        {
                
                for (int x = 0; x <= 50; x++)
                {
                        int answer = MathUtils.Power(x, y);
                        Console.WriteLine(answer);
                        
                }
        }
        public static double SquareRoot(int x)
        {
                foreach (int i in x)
                {
                      int answer =  Math.SquareRoot(x);
                      Console.WriteLine(answer);
                }
        }
        
         public static void AbsoluteValue(int x)
        {
                foreach (int i in x)
                {
                      int answer = Math.AbsoluteValue(x);
                      Console.WriteLine(answer);
                }
        }
         public static void Min(int x, int y)
        {
                
        }
         public static void Max(int x, int y)
        {
                
        }
         public static void Add(int x, int y)
        {
                foreach (int i in x)
                {
                      int answer = x + y;
                      Console.Writeline(answer);
                }
                
        }

         public static void Subtract(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer= x - y;
                        Console.WriteLine(answer);
                }
        }

         public static void Divide(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer = x / y;
                        Console.WriteLine(answer);
                }
        }

         public static void Multiply(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer = x * y;
                        Console.Writeline(answer);
                }
        }

         public static void Log(int x, int y)
        {
                
        }

         public static void Exponent(int x, int y)
        {
                
        }

         public static double Remainder(int x, int y)
        {
                double answer = x / y;
                double remainder = Math.Remainder(answer);
                Console.WriteLine(remainder);
        }

         public static double Round(int x)
        {
                double answer = Math.Round(x);
                Console.Writeline(answer);
        }
    }
}
