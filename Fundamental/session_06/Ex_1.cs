using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_06
{
    internal class Ex_1
    {
        // ===== MENU =====
        static void Menu()
        {
            Console.WriteLine("========== ARRAY EXERCISES MENU ==========");
            Console.WriteLine("PART 1");
            Console.WriteLine("1. Calculate average");
            Console.WriteLine("2. Check value exists");
            Console.WriteLine("3. Find index of element");
            Console.WriteLine("4. Remove specific element");
            Console.WriteLine("5. Find max and min");
            Console.WriteLine("6. Reverse array");
            Console.WriteLine("7. Find duplicate values");
            Console.WriteLine("8. Remove duplicate values");

            Console.WriteLine("\nPART 2");
            Console.WriteLine("9. Bubble Sort");
            Console.WriteLine("10. Linear Search");

            Console.WriteLine("\n0. Exit");
        }

        // ===== Create Random Array =====
        static int[] CreateRandomArray(int size)
        {
            Random rd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rd.Next(1, 20);
            }

            return arr;
        }

        // ===== Display Array =====
        static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Array: " + string.Join(" ", arr));
        }

        // ===== 1. Average =====
        static double Average(int[] arr)
        {
            return arr.Average();
        }

        // ===== 2. Check Exists =====
        static bool ContainsValue(int[] arr, int x)
        {
            return arr.Contains(x);
        }

        // ===== 3. Find Index =====
        static int FindIndex(int[] arr, int x)
        {
            return Array.IndexOf(arr, x);
        }

        // ===== 4. Remove Element =====
        static int[] RemoveElement(int[] arr, int x)
        {
            return arr.Where(n => n != x).ToArray();
        }

        // ===== 5. Max Min =====
        static void FindMaxMin(int[] arr)
        {
            Console.WriteLine("Max = " + arr.Max());
            Console.WriteLine("Min = " + arr.Min());
        }

        // ===== 6. Reverse Array =====
        static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            DisplayArray(arr);
        }

        // ===== 7. Find Duplicates =====
        static void FindDuplicates(int[] arr)
        {
            var duplicates = arr.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

            Console.WriteLine("Duplicate values: " + string.Join(" ", duplicates));
        }

        // ===== 8. Remove Duplicates =====
        static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        // ===== 9. Bubble Sort =====
        static void BubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            DisplayArray(arr);
        }

        // ===== 10. Linear Search =====
        static void LinearSearch(string sentence, string word)
        {
            string[] words = sentence.Split(' ');

            bool found = false;

            foreach (string w in words)
            {
                if (w.ToLower() == word.ToLower())
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Word found in sentence.");
            else
                Console.WriteLine("Word not found.");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Menu();

                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine()!);

                Console.WriteLine();

                int[] arr = CreateRandomArray(10);

                switch (choice)
                {
                    // ===== 1 =====
                    case 1:
                        Console.WriteLine("=== Calculate Average ===");
                        DisplayArray(arr);

                        Console.WriteLine("Average = " + Average(arr));
                        break;

                    // ===== 2 =====
                    case 2:
                        Console.WriteLine("=== Check Value Exists ===");
                        DisplayArray(arr);

                        Console.Write("Enter value to search: ");
                        int x1 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine(ContainsValue(arr, x1));
                        break;

                    // ===== 3 =====
                    case 3:
                        Console.WriteLine("=== Find Index ===");
                        DisplayArray(arr);

                        Console.Write("Enter value: ");
                        int x2 = int.Parse(Console.ReadLine()!);

                        Console.WriteLine("Index = " + FindIndex(arr, x2));
                        break;

                    // ===== 4 =====
                    case 4:
                        Console.WriteLine("=== Remove Element ===");
                        DisplayArray(arr);

                        Console.Write("Enter value to remove: ");
                        int x3 = int.Parse(Console.ReadLine()!);

                        int[] newArr = RemoveElement(arr, x3);

                        Console.WriteLine("Array after removing:");
                        DisplayArray(newArr);
                        break;

                    // ===== 5 =====
                    case 5:
                        Console.WriteLine("=== Find Max and Min ===");
                        DisplayArray(arr);

                        FindMaxMin(arr);
                        break;

                    // ===== 6 =====
                    case 6:
                        Console.WriteLine("=== Reverse Array ===");
                        DisplayArray(arr);

                        Console.WriteLine("Reversed array:");
                        ReverseArray(arr);
                        break;

                    // ===== 7 =====
                    case 7:
                        Console.WriteLine("=== Find Duplicates ===");
                        DisplayArray(arr);

                        FindDuplicates(arr);
                        break;

                    // ===== 8 =====
                    case 8:
                        Console.WriteLine("=== Remove Duplicates ===");
                        DisplayArray(arr);

                        int[] uniqueArr = RemoveDuplicates(arr);

                        Console.WriteLine("Array after removing duplicates:");
                        DisplayArray(uniqueArr);
                        break;

                    // ===== 9 =====
                    case 9:
                        Console.WriteLine("=== Bubble Sort ===");

                        int[] bubbleArr = new int[10];

                        Console.WriteLine("Enter 10 integers:");

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"Number {i + 1}: ");
                            bubbleArr[i] = int.Parse(Console.ReadLine()!);
                        }

                        BubbleSort(bubbleArr);
                        break;

                    // ===== 10 =====
                    case 10:
                        Console.WriteLine("=== Linear Search ===");

                        Console.Write("Enter a sentence: ");
                        string sentence = Console.ReadLine()!;

                        Console.Write("Enter a word to search: ");
                        string word = Console.ReadLine()!;

                        LinearSearch(sentence, word);
                        break;

                    // ===== Exit =====
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
