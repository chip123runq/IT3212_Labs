using System;

class Program
{
    static string DocDonVi(int n)
    {
        switch (n)
        {
            case 0: return "không";
            case 1: return "một";
            case 2: return "hai";
            case 3: return "ba";
            case 4: return "bốn";
            case 5: return "năm";
            case 6: return "sáu";
            case 7: return "bảy";
            case 8: return "tám";
            case 9: return "chín";
            default: return "";
        }
    }

    static string DocSo(int n)
    {
        if (n < 0 || n > 99)
            return "Số phải nằm trong khoảng 0 đến 99.";

        if (n < 10)
            return DocDonVi(n);

        if (n == 10)
            return "mười";

        int chuc = n / 10;
        int donVi = n % 10;

        string ketQua = chuc == 1
            ? "mười"
            : DocDonVi(chuc) + " mươi";

        if (donVi == 0)
            return ketQua;

        if (donVi == 1)
            ketQua += chuc == 1 ? " một" : " mốt";
        else if (donVi == 4)
            ketQua += chuc == 1 ? " bốn" : " tư";
        else if (donVi == 5)
            ketQua += " lăm";
        else
            ketQua += " " + DocDonVi(donVi);

        return ketQua;
    }

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên từ 0 đến 99: ");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Dữ liệu không hợp lệ.");
            return;
        }

        Console.WriteLine($"Cách đọc: {DocSo(n)}");
    }
}