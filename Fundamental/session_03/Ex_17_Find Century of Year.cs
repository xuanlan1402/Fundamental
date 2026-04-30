using System;


namespace Fundamental.session_03
{
    internal class Ex_17_Find_Century_of_Year
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            int century = (year - 1) / 100 + 1;

            Console.WriteLine("Year {0} belongs to century {1}", year, century);

            Console.ReadLine();
        }
    }
}
