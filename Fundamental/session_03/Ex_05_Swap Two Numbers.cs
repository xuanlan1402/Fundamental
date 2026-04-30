using System;
namespace Fundamental.session_03
{
    internal class Ex_05_Swap_Two_Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("\nAfter swapping: ");
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);

            Console.ReadLine();
        }
    }
}
