using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental.session_05
{
    internal class Ex_1
    {
        // ===== MENU =====
        static void Menu()
        {
            Console.WriteLine("========== MENU BÀI TẬP C# ==========");
            Console.WriteLine("1. Tính tổng hai số nguyên");
            Console.WriteLine("2. Kiểm tra số chẵn lẻ");
            Console.WriteLine("3. Tìm số lớn nhất");
            Console.WriteLine("4. Tính giai thừa");
            Console.WriteLine("5. Đảo ngược chuỗi");
            Console.WriteLine("6. Kiểm tra số nguyên tố");
            Console.WriteLine("7. In dãy Fibonacci");
            Console.WriteLine("8. Đếm nguyên âm");
            Console.WriteLine("9. Tính lũy thừa");
            Console.WriteLine("10. Tính trung bình mảng");
            Console.WriteLine("11. Kiểm tra Palindrome");
            Console.WriteLine("12. Đổi độ C sang F");
            Console.WriteLine("13. Tìm số nhỏ nhất");
            Console.WriteLine("14. Tổng các chữ số");
            Console.WriteLine("15. Sắp xếp mảng");
            Console.WriteLine("16. Xóa ký tự trùng");
            Console.WriteLine("17. Tìm UCLN");
            Console.WriteLine("18. Đổi sang nhị phân");
            Console.WriteLine("19. Kiểm tra năm nhuận");
            Console.WriteLine("20. Đếm số từ");
            Console.WriteLine("0. Thoát");
        }

        // ===== Bài 1 =====
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        // ===== Bài 2 =====
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        // ===== Bài 3 =====
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        // ===== Bài 4 =====
        static long TinhGiaiThua(int n)
        {
            long gt = 1;

            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }

            return gt;
        }

        // ===== Bài 5 =====
        static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // ===== Bài 6 =====
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // ===== Bài 7 =====
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        // ===== Bài 8 =====
        static int DemNguyenAm(string s)
        {
            int count = 0;

            foreach (char c in s.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }

            return count;
        }

        // ===== Bài 9 =====
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;

            for (int i = 1; i <= y; i++)
            {
                result *= x;
            }

            return result;
        }

        // ===== Bài 10 =====
        static double TinhTrungBinh(int[] arr)
        {
            return arr.Average();
        }

        // ===== Bài 11 =====
        static bool KiemTraDoiXung(string s)
        {
            return s == DaoNguocChuoi(s);
        }

        // ===== Bài 12 =====
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        // ===== Bài 13 =====
        static int TimMin(int[] arr)
        {
            return arr.Min();
        }

        // ===== Bài 14 =====
        static int TongCacChuSo(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        // ===== Bài 15 =====
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        // ===== Bài 16 =====
        static string XoaTrungLap(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                if (!result.Contains(c))
                    result += c;
            }

            return result;
        }

        // ===== Bài 17 =====
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // ===== Bài 18 =====
        static string DecimalToBinary(int n)
        {
            string binary = "";

            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            return binary;
        }

        // ===== Bài 19 =====
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        // ===== Bài 20 =====
        static int DemSoTu(string sentence)
        {
            return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();

                Menu();

                Console.Write("\nNhập lựa chọn: ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập a: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Nhập b: ");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tổng = " + TinhTong(a, b));
                        break;

                    case 2:
                        Console.Write("Nhập n: ");
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine(KiemTraChan(n) ? "Số chẵn" : "Số lẻ");
                        break;

                    case 3:
                        Console.Write("Nhập a: ");
                        int x = int.Parse(Console.ReadLine());

                        Console.Write("Nhập b: ");
                        int y = int.Parse(Console.ReadLine());

                        Console.Write("Nhập c: ");
                        int z = int.Parse(Console.ReadLine());

                        Console.WriteLine("Max = " + TimMax(x, y, z));
                        break;

                    case 4:
                        Console.Write("Nhập n: ");
                        int gt = int.Parse(Console.ReadLine());

                        Console.WriteLine("Giai thừa = " + TinhGiaiThua(gt));
                        break;

                    case 5:
                        Console.Write("Nhập chuỗi: ");
                        string s = Console.ReadLine();

                        Console.WriteLine("Chuỗi đảo ngược: " + DaoNguocChuoi(s));
                        break;

                    case 6:
                        Console.Write("Nhập n: ");
                        int nt = int.Parse(Console.ReadLine());

                        Console.WriteLine(KiemTraNguyenTo(nt));
                        break;

                    case 7:
                        Console.Write("Nhập số Fibonacci: ");
                        int fib = int.Parse(Console.ReadLine());

                        InFibonacci(fib);
                        break;

                    case 8:
                        Console.Write("Nhập chuỗi: ");
                        string str = Console.ReadLine();

                        Console.WriteLine("Số nguyên âm = " + DemNguyenAm(str));
                        break;

                    case 9:
                        Console.Write("Nhập x: ");
                        double xx = double.Parse(Console.ReadLine());

                        Console.Write("Nhập y: ");
                        int yy = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kết quả = " + TinhLuyThua(xx, yy));
                        break;

                    case 10:
                        int[] arr1 = { 4, 5, 6, 7 };
                        Console.WriteLine("Trung bình = " + TinhTrungBinh(arr1));
                        break;

                    case 11:
                        Console.Write("Nhập chuỗi: ");
                        string dx = Console.ReadLine();

                        Console.WriteLine(KiemTraDoiXung(dx));
                        break;

                    case 12:
                        Console.Write("Nhập độ C: ");
                        double c = double.Parse(Console.ReadLine());

                        Console.WriteLine("Độ F = " + CelsiusToFahrenheit(c));
                        break;

                    case 13:
                        int[] arr2 = { 10, 5, 8, 2, 9 };
                        Console.WriteLine("Min = " + TimMin(arr2));
                        break;

                    case 14:
                        Console.Write("Nhập số: ");
                        int so = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tổng chữ số = " + TongCacChuSo(so));
                        break;

                    case 15:
                        int[] arr3 = { 3, 1, 4, 2 };
                        SapXepMang(arr3);
                        break;

                    case 16:
                        Console.Write("Nhập chuỗi: ");
                        string trunglap = Console.ReadLine();

                        Console.WriteLine(XoaTrungLap(trunglap));
                        break;

                    case 17:
                        Console.Write("Nhập a: ");
                        int aa = int.Parse(Console.ReadLine());

                        Console.Write("Nhập b: ");
                        int bb = int.Parse(Console.ReadLine());

                        Console.WriteLine("UCLN = " + UCLN(aa, bb));
                        break;

                    case 18:
                        Console.Write("Nhập số thập phân: ");
                        int thapphan = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nhị phân = " + DecimalToBinary(thapphan));
                        break;

                    case 19:
                        Console.Write("Nhập năm: ");
                        int nam = int.Parse(Console.ReadLine());

                        Console.WriteLine(KiemTraNamNhuan(nam));
                        break;

                    case 20:
                        Console.Write("Nhập câu: ");
                        string cau = Console.ReadLine();

                        Console.WriteLine("Số từ = " + DemSoTu(cau));
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
            }
        }
    }
}
