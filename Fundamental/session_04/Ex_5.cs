using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine());

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("Vowel");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Other symbol");
            }

            Console.ReadLine();
        }
    }
}
