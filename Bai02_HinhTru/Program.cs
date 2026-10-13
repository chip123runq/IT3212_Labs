using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập bán kính r: ");
        if (!double.TryParse(Console.ReadLine(), out double r) || r <= 0)
        {
            Console.WriteLine("Bán kính phải là số dương.");
            return;
        }

        Console.Write("Nhập chiều cao h: ");
        if (!double.TryParse(Console.ReadLine(), out double h) || h <= 0)
        {
            Console.WriteLine("Chiều cao phải là số dương.");
            return;
        }

        double dienTichXQ = 2 * Math.PI * r * h;
        double theTich = Math.PI * r * r * h;

        Console.WriteLine($"Diện tích xung quanh: {dienTichXQ:N2}");
        Console.WriteLine($"Thể tích hình trụ: {theTich:N2}");
    }
}