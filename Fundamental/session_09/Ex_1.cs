using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_09
{
    internal class Ex_1
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n===== FILE HANDLING MENU =====");
                Console.WriteLine("1. Create a blank file");
                Console.WriteLine("2. Delete a file");
                Console.WriteLine("3. Create a file and add text");
                Console.WriteLine("4. Read a text file");
                Console.WriteLine("5. Write an array of strings to a file");
                Console.WriteLine("6. Append text to a file");
                Console.WriteLine("7. Copy a file and display content");
                Console.WriteLine("8. Move a file with another name");
                Console.WriteLine("9. Read first line of a file");
                Console.WriteLine("10. Read last line of a file");
                Console.WriteLine("11. Read last N lines of a file");
                Console.WriteLine("12. Read a specific line");
                Console.WriteLine("13. Count number of lines");
                Console.WriteLine("14. Print folder structure");
                Console.WriteLine("15. Count characters and digits");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: CreateBlankFile(); break;
                    case 2: DeleteFile(); break;
                    case 3: CreateFileWithText(); break;
                    case 4: ReadTextFile(); break;
                    case 5: WriteArrayToFile(); break;
                    case 6: AppendText(); break;
                    case 7: CopyFile(); break;
                    case 8: MoveFile(); break;
                    case 9: ReadFirstLine(); break;
                    case 10: ReadLastLine(); break;
                    case 11: ReadLastNLines(); break;
                    case 12: ReadSpecificLine(); break;
                    case 13: CountLines(); break;
                    case 14: PrintFolderStructure(); break;
                    case 15: CountCharactersAndDigits(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        static void CreateBlankFile()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();
            File.Create(file).Close();
            Console.WriteLine("File created.");
        }

        static void DeleteFile()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            if (File.Exists(file))
            {
                File.Delete(file);
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static void CreateFileWithText()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            File.WriteAllText(file, text);
            Console.WriteLine("Text written.");
        }

        static void ReadTextFile()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            if (File.Exists(file))
                Console.WriteLine(File.ReadAllText(file));
            else
                Console.WriteLine("File not found.");
        }

        static void WriteArrayToFile()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            string[] arr =
            {
            "Apple",
            "Banana",
            "Orange",
            "Mango"
        };

            File.WriteAllLines(file, arr);
            Console.WriteLine("Array written.");
        }

        static void AppendText()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            Console.Write("Enter text to append: ");
            string text = Console.ReadLine();

            File.AppendAllText(file, text + Environment.NewLine);
            Console.WriteLine("Text appended.");
        }

        static void CopyFile()
        {
            Console.Write("Source file: ");
            string source = Console.ReadLine();

            Console.Write("Destination file: ");
            string dest = Console.ReadLine();

            File.Copy(source, dest, true);

            Console.WriteLine("Copied content:");
            Console.WriteLine(File.ReadAllText(dest));
        }

        static void MoveFile()
        {
            Console.Write("Source file: ");
            string source = Console.ReadLine();

            Console.Write("New file name: ");
            string dest = Console.ReadLine();

            File.Move(source, dest);
            Console.WriteLine("File moved.");
        }

        static void ReadFirstLine()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            string firstLine = File.ReadLines(file).FirstOrDefault();
            Console.WriteLine("First line: " + firstLine);
        }

        static void ReadLastLine()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            string lastLine = File.ReadLines(file).LastOrDefault();
            Console.WriteLine("Last line: " + lastLine);
        }

        static void ReadLastNLines()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            string[] lines = File.ReadAllLines(file);

            Console.WriteLine($"Last {n} lines:");
            foreach (string line in lines.Skip(Math.Max(0, lines.Length - n)))
            {
                Console.WriteLine(line);
            }
        }

        static void ReadSpecificLine()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            Console.Write("Line number: ");
            int num = int.Parse(Console.ReadLine());

            string[] lines = File.ReadAllLines(file);

            if (num > 0 && num <= lines.Length)
                Console.WriteLine(lines[num - 1]);
            else
                Console.WriteLine("Invalid line number.");
        }

        static void CountLines()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            int count = File.ReadAllLines(file).Length;
            Console.WriteLine("Number of lines: " + count);
        }

        static void PrintFolderStructure()
        {
            Console.Write("Enter folder path: ");
            string path = Console.ReadLine();

            PrintDirectory(path, 0);
        }

        static void PrintDirectory(string path, int level)
        {
            string indent = new string(' ', level * 4);

            foreach (string dir in Directory.GetDirectories(path))
            {
                Console.WriteLine(indent + "[DIR] " + Path.GetFileName(dir));
                PrintDirectory(dir, level + 1);
            }

            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(indent + Path.GetFileName(file));
            }
        }

        static void CountCharactersAndDigits()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            string content = File.ReadAllText(file);

            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            int digitCount = 0;

            foreach (char c in content)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }

                if (!char.IsWhiteSpace(c))
                {
                    if (charsCount.ContainsKey(c))
                        charsCount[c]++;
                    else
                        charsCount[c] = 1;
                }
            }

            Console.WriteLine("\nCharacter Frequency:");
            foreach (var item in charsCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine($"\nTotal digits: {digitCount}");
        }
    }
}
