using System;
namespace Fundamental.session_04
{
    internal class Ex_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, x, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '*':
                case 'x': // hỗ trợ cả dấu x
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
