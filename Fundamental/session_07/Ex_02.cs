using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_07
{
    internal class Ex_02
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("21. Nhap va xuat ma tran");
                Console.WriteLine("22. Tong tung dong va tung cot");
                Console.WriteLine("23. Tim Max va vi tri");
                Console.WriteLine("24. Liet ke duong cheo chinh");
                Console.WriteLine("25. Tong duong cheo phu");
                Console.WriteLine("26. Tim kiem X trong ma tran");
                Console.WriteLine("27. Dem so am tren bien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==========================");

                Console.Write("Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 21:
                        Bai21();
                        break;

                    case 22:
                        Bai22();
                        break;

                    case 23:
                        Bai23();
                        break;

                    case 24:
                        Bai24();
                        break;

                    case 25:
                        Bai25();
                        break;

                    case 26:
                        Bai26();
                        break;

                    case 27:
                        Bai27();
                        break;

                    case 0:
                        Console.WriteLine("Thoat chuong trinh...");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (choice != 0);
        }

        // ===== Hàm nhập ma trận =====
        static int[,] NhapMaTran(out int m, out int n)
        {
            Console.Write("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot n: ");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }

            return a;
        }

        // ===== BÀI 21 =====
        static void Bai21()
        {
            int m, n;
            int[,] a = NhapMaTran(out m, out n);

            Console.WriteLine("Ma tran vua nhap:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // ===== BÀI 22 =====
        static void Bai22()
        {
            int m, n;
            int[,] a = NhapMaTran(out m, out n);

            Console.WriteLine("Tong tung dong:");

            for (int i = 0; i < m; i++)
            {
                int sumRow = 0;

                for (int j = 0; j < n; j++)
                {
                    sumRow += a[i, j];
                }

                Console.Write(sumRow + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Tong tung cot:");

            for (int j = 0; j < n; j++)
            {
                int sumCol = 0;

                for (int i = 0; i < m; i++)
                {
                    sumCol += a[i, j];
                }

                Console.Write(sumCol + " ");
            }

            Console.WriteLine();
        }

        // ===== BÀI 23 =====
        static void Bai23()
        {
            int m, n;
            int[,] a = NhapMaTran(out m, out n);

            int max = a[0, 0];
            int row = 0;
            int col = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine("Max = " + max + " tai hang " + row + ", cot " + col);
        }

        // ===== BÀI 24 =====
        static void Bai24()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine("Duong cheo chinh:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i, i] + " ");
            }

            Console.WriteLine();
        }

        // ===== BÀI 25 =====
        static void Bai25()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a[i, n - 1 - i];
            }

            Console.WriteLine("Tong duong cheo phu = " + sum);
        }

        // ===== BÀI 26 =====
        static void Bai26()
        {
            int m, n;
            int[,] a = NhapMaTran(out m, out n);

            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());

            bool found = false;

            Console.WriteLine("Vi tri tim thay:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine("(" + i + ", " + j + ")");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("NOT FOUND");
            }
        }

        // ===== BÀI 27 =====
        static void Bai27()
        {
            int m, n;
            int[,] a = NhapMaTran(out m, out n);

            int count = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isBorder =
                        i == 0 ||
                        i == m - 1 ||
                        j == 0 ||
                        j == n - 1;

                    if (isBorder && a[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("So am tren bien = " + count);
        }
    }
}
