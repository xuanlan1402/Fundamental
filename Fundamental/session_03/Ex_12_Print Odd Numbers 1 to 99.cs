using System;
using System.Security.Cryptography;

namespace Fundamental.session_03
{
    internal class Ex_12_Print_Odd_Numbers_1_to_99
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd number from 1 to 99. Prints one number per line.");

            for (int i = 1; i <= 99; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
