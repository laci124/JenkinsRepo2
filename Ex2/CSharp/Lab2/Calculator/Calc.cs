using System;

namespace Calculator
{
    public class Calc
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Devide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("[Multiply] b=0.");
                return 0;
            }

            return a / b;
        }

    }
}
