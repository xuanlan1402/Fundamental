using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_08
{
    internal class Ex_1
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n========== STRING MENU ==========");
                Console.WriteLine("1. Input and print string");
                Console.WriteLine("2. Find string length");
                Console.WriteLine("3. Separate characters");
                Console.WriteLine("4. Reverse characters");
                Console.WriteLine("5. Count words");
                Console.WriteLine("6. Compare two strings");
                Console.WriteLine("7. Count alphabets, digits, special characters");
                Console.WriteLine("8. Count vowels and consonants");
                Console.WriteLine("9. Check substring exists");
                Console.WriteLine("10. Find substring position");
                Console.WriteLine("11. Check alphabet and case");
                Console.WriteLine("12. Count substring occurrences");
                Console.WriteLine("13. Insert substring before first occurrence");
                Console.WriteLine("0. Exit");
                Console.WriteLine("=================================");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Bai1();
                        break;

                    case 2:
                        Bai2();
                        break;

                    case 3:
                        Bai3();
                        break;

                    case 4:
                        Bai4();
                        break;

                    case 5:
                        Bai5();
                        break;

                    case 6:
                        Bai6();
                        break;

                    case 7:
                        Bai7();
                        break;

                    case 8:
                        Bai8();
                        break;

                    case 9:
                        Bai9();
                        break;

                    case 10:
                        Bai10();
                        break;

                    case 11:
                        Bai11();
                        break;

                    case 12:
                        Bai12();
                        break;

                    case 13:
                        Bai13();
                        break;

                    case 0:
                        Console.WriteLine("Exit program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }

        // ===== 1 =====
        static void Bai1()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("You entered: " + str);
        }

        // ===== 2 =====
        static void Bai2()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int length = 0;

            foreach (char c in str)
            {
                length++;
            }

            Console.WriteLine("Length = " + length);
        }

        // ===== 3 =====
        static void Bai3()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Characters:");

            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }

        // ===== 4 =====
        static void Bai4()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Reverse: ");

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }

        // ===== 5 =====
        static void Bai5()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int count = 0;

            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if (word != "")
                {
                    count++;
                }
            }

            Console.WriteLine("Total words = " + count);
        }

        // ===== 6 =====
        static void Bai6()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool equal = true;

            if (str1.Length != str2.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
                Console.WriteLine("Strings are equal");
            else
                Console.WriteLine("Strings are NOT equal");
        }

        // ===== 7 =====
        static void Bai7()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int alphabets = 0;
            int digits = 0;
            int special = 0;

            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    alphabets++;
                else if (c >= '0' && c <= '9')
                    digits++;
                else
                    special++;
            }

            Console.WriteLine("Alphabets = " + alphabets);
            Console.WriteLine("Digits = " + digits);
            Console.WriteLine("Special characters = " + special);
        }

        // ===== 8 =====
        static void Bai8()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels = " + vowels);
            Console.WriteLine("Consonants = " + consonants);
        }

        // ===== 9 =====
        static void Bai9()
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            if (str.Contains(sub))
                Console.WriteLine("Substring found");
            else
                Console.WriteLine("Substring NOT found");
        }

        // ===== 10 =====
        static void Bai10()
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            int position = str.IndexOf(sub);

            Console.WriteLine("Position = " + position);
        }

        // ===== 11 =====
        static void Bai11()
        {
            Console.Write("Enter a character: ");
            char c = char.Parse(Console.ReadLine());

            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                Console.WriteLine("It is an alphabet");

                if (c >= 'A' && c <= 'Z')
                    Console.WriteLine("Uppercase letter");
                else
                    Console.WriteLine("Lowercase letter");
            }
            else
            {
                Console.WriteLine("It is NOT an alphabet");
            }
        }

        // ===== 12 =====
        static void Bai12()
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            int count = 0;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                    count++;
            }

            Console.WriteLine("Occurrences = " + count);
        }

        // ===== 13 =====
        static void Bai13()
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter target string: ");
            string target = Console.ReadLine();

            Console.Write("Enter substring to insert: ");
            string insert = Console.ReadLine();

            int pos = str.IndexOf(target);

            if (pos != -1)
            {
                string result = str.Insert(pos, insert);

                Console.WriteLine("Result = " + result);
            }
            else
            {
                Console.WriteLine("Target string not found");

            }
        }
    }
}
