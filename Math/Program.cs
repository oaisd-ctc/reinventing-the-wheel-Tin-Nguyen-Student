
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
                foreach (int i in x)
                {
                      int answer =  Math.SquareRoot(x);
                      Console.WriteLine(answer);
                      return;
                }
        }
        
         public static void AbsoluteValue(int x)
        {
                foreach (int i in x)
                {
                      int answer = Math.AbsoluteValue(x);
                      Console.WriteLine(answer);
                      return;
                }
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
         public static void Add(int x, int y)
        {
                foreach (int i in x)
                {
                      int answer = x + y;
                      Console.Writeline(answer);
                      return;
                }
                
        }

         public static void Subtract(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer= x - y;
                        Console.WriteLine(answer);
                        return;
                }
        }

         public static void Divide(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer = x / y;
                        Console.WriteLine(answer);
                        return;
                }
        }

         public static void Multiply(int x, int y)
        {
                foreach (int i in x)
                {
                        int answer = x * y;
                        Console.Writeline(answer);
                        return;
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
