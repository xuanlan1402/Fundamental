using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine("Surface Area = " + surface);
            Console.WriteLine("Volume = " + volume);

            Console.ReadLine();
        }
    }
}
