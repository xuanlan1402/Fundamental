using System;

namespace Fundamental.session_03
{
    internal class Ex_16_Rotate_Array_Left
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("Original array: [{0}]", string.Join(", ", nums));

            int temp = nums[0];

            nums[0] = nums[1];

            nums[1] = nums[2];

            nums[2] = temp;

            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", nums));

            Console.ReadLine();
        }
    }
}
