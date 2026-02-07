using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line:");

            double g1 = Convert.ToDouble(Console.ReadLine());
            double g2 = Convert.ToDouble(Console.ReadLine());
            double g3 = Convert.ToDouble(Console.ReadLine());
            double g4 = Convert.ToDouble(Console.ReadLine());
            double g5 = Convert.ToDouble(Console.ReadLine());

            double average = (g1 + g2 + g3 + g4 + g5) / 5;

            int roundedAverage = (int)Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + roundedAverage);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}