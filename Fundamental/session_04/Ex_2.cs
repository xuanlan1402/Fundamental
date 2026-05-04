using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y\t x");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t {x}");
            }

            Console.ReadLine();
        }
    }
}
