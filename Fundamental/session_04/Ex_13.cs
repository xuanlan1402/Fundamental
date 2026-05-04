using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int n = int.Parse(Console.ReadLine());

            // 🔹 Pattern 1
            Console.WriteLine("\nPattern 1:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            // 🔹 Pattern 2
            Console.WriteLine("\nPattern 2:");
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

            // 🔹 Pattern 3
            Console.WriteLine("\nPattern 3:");
            num = 1;
            for (int i = 1; i <= n; i++)
            {
                // khoảng trắng để canh giữa
                for (int s = 1; s <= n - i; s++)
                    Console.Write(" ");

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
