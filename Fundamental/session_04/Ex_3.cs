using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance (km): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Enter hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Enter seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            // Convert time to hours
            double totalTime = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Calculate speeds
            double speedKmh = distance / totalTime;
            double speedMph = speedKmh * 0.621371;

            Console.WriteLine("Speed in km/h = " + speedKmh);
            Console.WriteLine("Speed in miles/h = " + speedMph);

            Console.ReadLine();
        }
    }
}
