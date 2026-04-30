using System;
namespace Fundamental.session_03
{
    internal class Ex_02_Sum_of_Two_Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);

            Console.ReadLine();
        }
    }
}
