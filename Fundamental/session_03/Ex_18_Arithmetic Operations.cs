using System;

namespace Fundamental.session_03
{
    internal class Ex_18_Arithmetic_Operations
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second nunber: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 + num2);

            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);

            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

            Console.ReadLine();
        }
    }
}
