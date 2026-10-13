using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n===== MENU VẼ HÌNH =====");
            Console.WriteLine("1. Tam giác vuông đặc");
            Console.WriteLine("2. Tam giác vuông rỗng");
            Console.WriteLine("3. Hình vuông rỗng");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                continue;
            }

            if (chon == 0)
                break;

            if (chon < 1 || chon > 3)
            {
                Console.WriteLine("Vui lòng chọn từ 0 đến 3.");
                continue;
            }

            Console.Write("Nhập kích thước n: ");

            if (!int.TryParse(Console.ReadLine(), out int n)
                || n < 1 || n > 50)
            {
                Console.WriteLine("n phải nằm trong khoảng 1 đến 50.");
                continue;
            }

            switch (chon)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(new string('*', i));
                    }
                    break;

                case 2:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == i)
                                Console.Write('*');
                            else
                                Console.Write(' ');
                        }

                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                                Console.Write('*');
                            else
                                Console.Write(' ');
                        }

                        Console.WriteLine();
                    }
                    break;
            }
        }

        Console.WriteLine("Kết thúc chương trình.");
    }
}