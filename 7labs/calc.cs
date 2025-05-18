using System;
using System.Collections.Generic;

namespace ExceptionHandlingExample
{
    class Calculation
    {
        public double A { get; set; }
        public double C { get; set; }

        public Calculation(double a, double c)
        {
            A = a;
            C = c;
        }

        public double CalculateExpression()
        {
            if (C == -A)
                throw new ArgumentException("Division by zero is not allowed.");

            return Math.Log((2 * C - A) + 4 - 152) / (A / C);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Calculation> calculations = new List<Calculation>
            {
                new Calculation(4, 2),
                new Calculation(5, -5),
                new Calculation(3, 3)
            };

            foreach (var calc in calculations)
            {
                try
                {
                    Console.WriteLine($"Result: {calc.CalculateExpression()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
