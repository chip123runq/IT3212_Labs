using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Tính tổng từ 1 đến n");
            Console.WriteLine("2. In bảng cửu chương");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui lòng nhập số nguyên.");
                continue;
            }

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập n: ");

                    if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
                    {
                        Console.WriteLine("n phải là số nguyên dương.");
                        break;
                    }

                    long tong = (long)n * (n + 1) / 2;
                    Console.WriteLine($"Tổng từ 1 đến {n} = {tong}");
                    break;

                case 2:
                    Console.Write("Nhập số cần in bảng cửu chương: ");

                    if (!int.TryParse(Console.ReadLine(), out int so))
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ.");
                        break;
                    }

                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine($"{so} x {i} = {(long)so * i}");
                    break;

                case 0:
                    Console.WriteLine("Đã thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (chon != 0);
    }
}