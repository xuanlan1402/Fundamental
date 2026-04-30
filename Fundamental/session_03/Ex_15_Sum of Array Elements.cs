using System;
using System.Xml.Linq;

namespace Fundamental.session_03
{
    internal class Ex_15_Sum_of_Array_Elements
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }

            Console.WriteLine("Array1: [{0}]", string.Join(", ", numbers));
            Console.WriteLine("Sum: " + sum);

            Console.ReadLine();
        }
    }
}
