using System;

namespace Fundamental.session_03
{
    internal class Ex_08_Celsius_to_Kelvin_and_Fahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount ò celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double kelvin = celsius + 273;
            double fahrenheit = (celsius * 18/ 10) + 32;

            Console.WriteLine("Expected output: ");
            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);

            Console.ReadLine();
        }
    }
}
