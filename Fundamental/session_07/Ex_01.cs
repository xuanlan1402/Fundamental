using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_07
{
    internal class Ex_01
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Nhap va xuat mang");
                Console.WriteLine("2. Tong va trung binh cong");
                Console.WriteLine("3. Tim Max va Min");
                Console.WriteLine("4. Dem so chan va le");
                Console.WriteLine("5. Tim kiem trong mang");
                Console.WriteLine("6. Dao nguoc mang");
                Console.WriteLine("7. Kiem tra mang doi xung");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==========================");
                Console.Write("Nhap lua chon: ");

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

                    case 0:
                        Console.WriteLine("Thoat chuong trinh...");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (choice != 0);
        }

        // ================= BAI 1 =================
        static void Bai1()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap cac phan tu:");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Console.WriteLine("Mang vua nhap:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        // ================= BAI 2 =================
        static void Bai2()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            Console.WriteLine("Nhap cac so thuc:");
            string[] input = Console.ReadLine().Split();

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(input[i]);
                sum += arr[i];
            }

            double avg = sum / n;

            Console.WriteLine("Tong = " + sum);
            Console.WriteLine("Trung binh cong = " + avg.ToString("F2"));
        }

        // ================= BAI 3 =================
        static void Bai3()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap mang:");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }

        // ================= BAI 4 =================
        static void Bai4()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap mang:");
            string[] input = Console.ReadLine().Split();

            int chan = 0;
            int le = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);

                if (arr[i] % 2 == 0)
                    chan++;
                else
                    le++;
            }

            Console.WriteLine("So chan = " + chan);
            Console.WriteLine("So le = " + le);
        }

        // ================= BAI 5 =================
        static void Bai5()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap mang:");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int position = -1;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    position = i;
                    break;
                }
            }

            Console.WriteLine("Vi tri: " + position);
        }

        // ================= BAI 6 =================
        static void Bai6()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap mang:");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }

            Console.WriteLine("Mang sau khi dao nguoc:");

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        // ================= BAI 7 =================
        static void Bai7()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap mang:");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            bool doiXung = true;

            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - 1 - i])
                {
                    doiXung = false;
                    break;
                }
            }

            if (doiXung)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
