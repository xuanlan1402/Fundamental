using System;
namespace Fundamental.session_03
{
    internal class Ex_04_Multiply_Three_Numbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;

            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            result = num1 * num2 * num3;

            Console.WriteLine("\nExpected Output: ");
            Console.WriteLine("{0} x {1} x {2} = {3}", num1, num2, num3, result);

            Console.ReadLine();
        }
    }
}
