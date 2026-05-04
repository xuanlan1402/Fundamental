using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_9
    {
        static void Main(string[] args)
        {
            Console.Write("Input side 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input side 2: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Input side 3: ");
            double c = double.Parse(Console.ReadLine());


            if (a + b > c && a + c > b && b + c > a)
            {

                if (a == b && b == c)
                {
                    Console.WriteLine("This is an Equilateral triangle (Tam giác đều).");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an Isosceles triangle (Tam giác cân).");
                }
                else
                {
                    Console.WriteLine("This is a Scalene triangle (Tam giác thường).");
                }
            }
            else
            {
                Console.WriteLine("These sides do not form a triangle.");
            }

            Console.ReadLine();
        }
    }
}
