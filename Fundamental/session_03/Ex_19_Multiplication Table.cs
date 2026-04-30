using System;

namespace Fundamental.session_03
{
    internal class Ex_19_Multiplication_Table
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
            Console.ReadLine();
        }
    }
}
