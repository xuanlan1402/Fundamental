using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            Console.Write("Harmonic series: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");

                if (i < n) Console.Write(" + ");

                sum += 1.0 / i;
            }

            Console.WriteLine($"\nSum = {sum}");

            Console.ReadLine();
        }
    }
}
