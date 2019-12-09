using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5;  double b = 3.8;

            Console.WriteLine("Add a+b: " + a + " + " + b + " = " + Calculator.Add(a,b) );
            Console.WriteLine("Add a-b: " + a + " - " + b + " = " + Calculator.Subtract(a, b));
            Console.WriteLine("Add a*b: " + a + " * " + b + " = " + Calculator.Multiply(a, b));
            Console.WriteLine("Add a/b: " + a + " / " + b + " = " + Calculator.Devide(a, b));

            Thread.Sleep(5000);

        }
    }
}
