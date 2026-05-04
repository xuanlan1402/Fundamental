using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect numbers:");

            for (int n = start; n <= end; n++)
            {
                int sum = 0;

                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        sum += i;
                }

                if (sum == n && n != 0)
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadLine();
        }
    }
}
