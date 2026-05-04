using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("Largest number = " + max);

            Console.ReadLine();
        }
    }
}
