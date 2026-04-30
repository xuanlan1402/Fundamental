using System;

namespace Fundamental.session_03
{
    internal class Ex_13_File_Size_in_Bytes
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";

            File.WriteAllText(filePath, "Hello world! This is a test.");

            FileInfo fileInfo = new FileInfo(filePath);

            long bytes = fileInfo.Length;

            Console.WriteLine("Size of a file: " + bytes);
            Console.ReadLine();
        }
    }
}
