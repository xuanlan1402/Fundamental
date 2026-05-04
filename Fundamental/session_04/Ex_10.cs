using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_04
{
    internal class Ex_10
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int sum = 0;

            Console.WriteLine("Input the 10 numbers:");


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number-{0} : ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());


                sum += numbers[i];
            }


            double average = (double)sum / 10;


            Console.WriteLine("\nThe sum of 10 numbers is : {0}", sum);
            Console.WriteLine("The Average is : {0}", average);

            Console.ReadLine();
        }
    }
}
