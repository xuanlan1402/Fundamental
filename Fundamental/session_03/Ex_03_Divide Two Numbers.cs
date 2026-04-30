using System;
namespace Fundamental.session_03
{
    internal class Ex_03_Divide_Two_Numbers
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int result1 = a / b;

            double x = 10;
            double y = 3;
            double result2 = x / y;

            Console.WriteLine("---Phep chia so nguyen---");
            Console.WriteLine("10 chia 3 bang: " + result1);

            Console.WriteLine("\n---Phep chia so thap phan---");
            Console.WriteLine("10 chia 3 bang: " + result2);

            Console.ReadLine();
        }
    }
}
