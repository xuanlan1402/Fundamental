using System;

namespace Fundamental.session_03
{
    internal class Ex_10_Check_Positive_and_Negative_Pair
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int second = int.Parse(Console.ReadLine());

            bool result = (first < 0 && second >0) || (first >0  && second < 0);

            Console.WriteLine("Check if one is negative and one is positive: ");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
