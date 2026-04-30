using System;

namespace Fundamental.session_03
{
    internal class Ex_09_Remove_Character_by_Index
    {
        static void Main(string[] args)
        {
            string str = "w3resource";
            Console.WriteLine("Original string: " + str);

            Console.WriteLine("After removing index 1: " + str.Remove(1, 1));

            Console.WriteLine("After removing index 9: " + str.Remove(9, 1));

            Console.WriteLine("After removing index 0: " + str.Remove(0, 1));

            Console.ReadLine();
        }
    }
}
