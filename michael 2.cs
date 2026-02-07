using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BermioMichaelJohnJoshua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 15.75;
            double number2 = -20.0;
            double baseNum = 2.0;
            double exponent = 3.0;

            Console.WriteLine("Absolute value of " + number2 + " is: " + Math.Abs(number2));
            Console.WriteLine("Higher value between " + number1 + " and 10 is: " + Math.Max(number1, 10));
            Console.WriteLine(baseNum + " to the power of " + exponent + " is: " + Math.Pow(baseNum, exponent));
            Console.WriteLine("Square root of 144 is: " + Math.Sqrt(144));
            Console.WriteLine("Ceiling value of " + number1 + " is: " + Math.Ceiling(number1));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
