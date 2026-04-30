using System;

namespace Fundamental.session_03
{
    internal class Ex_07_Print_Age_Message
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age - ");

            string age = Console.ReadLine();

            Console.WriteLine("You look older than " + age);

            Console.ReadLine();
        }
    }
}
