using System;

namespace Fundamental.session_03
{
    internal class Ex_11_Sum_or_Triple_Sum_of_Integers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Input second integer: ");
            int n2 = int.Parse(Console.ReadLine());

            int result;

            if (n1 == n2)
            {
                result = (n1 + n2) * 3;
                Console.WriteLine("\nTwo values are the same!");
                Console.WriteLine("Triple of their sum: " + result);
            }
            else
            {
                result = n1 + n2;
                Console.WriteLine("\nSum of two integer: " + result);
            }

            Console.ReadLine();
        }
    }
}
