using System;

namespace Fundamental.session_03
{
    internal class Ex_14_Sum_of_Digits_in_Integer
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number(integer): ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                sum += temp % 10;

                temp = temp / 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);

            Console.ReadLine();
        }
    }
}
