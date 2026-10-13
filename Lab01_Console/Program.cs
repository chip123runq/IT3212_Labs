using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Họ và tên: ");
        string hoTen = Console.ReadLine() ?? "";

        Console.Write("Năm sinh: ");
        if (!int.TryParse(Console.ReadLine(), out int namSinh)
            || namSinh <= 0 || namSinh > DateTime.Now.Year)
        {
            Console.WriteLine("Năm sinh không hợp lệ.");
            return;
        }

        int tuoi = DateTime.Now.Year - namSinh;

        Console.WriteLine("\n===== THÔNG TIN CÁ NHÂN =====");
        Console.WriteLine($"Họ và tên: {hoTen}");
        Console.WriteLine($"Năm sinh: {namSinh}");
        Console.WriteLine($"Tuổi gần đúng: {tuoi}");
    }
}