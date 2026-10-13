using System;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= n / i; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập n: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
        {
            Console.WriteLine("Vui lòng nhập n >= 2.");
            return;
        }

        Console.WriteLine($"Các số nguyên tố không vượt quá {n}:");

        for (int i = 2; i <= n; i++)
        {
            if (LaSoNguyenTo(i))
                Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}