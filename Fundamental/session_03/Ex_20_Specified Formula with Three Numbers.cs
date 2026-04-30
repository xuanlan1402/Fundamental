using System;

namespace Fundamental.session_03
{
    internal class Ex_20_Specified_Formula_with_Three_Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number - ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number - ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Enter third number - ");
            int z = int.Parse(Console.ReadLine());

            int result1 = (x + y) * z;

            int result2 = x * y + y * z;

            Console.WriteLine("\nResult of specified numbers {0}, {1} and {2}, {x+y}.z is {3} and x.y + y.z is {4}", x, y, z, result1, result2);

            Console.ReadLine();
        }
    }
}
