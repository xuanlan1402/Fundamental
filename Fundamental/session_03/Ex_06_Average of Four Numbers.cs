using System;
namespace Fundamental.session_03
{
    internal class Ex_06_Average_of_Four_Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double n4 = double.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("\nThe average of {0}, {1}, {2}, {3}, {4}", n1, n2, n3, n4, average);

            Console.ReadLine();
        }
    }
}
