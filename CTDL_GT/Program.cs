using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
internal class Btapbuoi1
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số thứ 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ 3: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine($"Lớn nhất: {max(a, b, c)}; nhỏ nhất: {min(a, b, c)}; tổng: {tong(a, b, c)}; trung bình: {trungbinh(a, b, c):N2}");
        Console.Write("Nhập số phần tử của mảng(2<=n<=100000): ");
        int n = int.Parse(Console.ReadLine());
        if (n < 2 || n > 100000)
            return;
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Số nguyên thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        duyetso(arr);
        int[] mang1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] mang2 = { -8, -3, -6, -2, -5, -4 };
        int[] mang3 = { 1, 2, 3 };
        Console.WriteLine("Mang 1. Phien ban A: " + PhienBanA(mang1) + " | Phien ban B: " + PhienBanB(mang1));
        Console.WriteLine("Mang 2. Phien ban A: " + PhienBanA(mang2) + " | Phien ban B: " + PhienBanB(mang2));
        Console.WriteLine("Mang 3. Phien ban A: " + PhienBanA(mang3) + " | Phien ban B: " + PhienBanB(mang3));
        Console.WriteLine("--- DO THOI GIAN ---");
        // Khởi tạo mảng ngẫu nhiên 10,000 phần tử để đo
        int o = 10000;
        int[] data = new int[o];
        Random rand = new Random();
        for (int i = 0; i < o; i++)
        {
            data[i] = rand.Next(-100, 100);
        }
        System.Diagnostics.Stopwatch stopwatchA = System.Diagnostics.Stopwatch.StartNew();
        PhienBanA(data);
        stopwatchA.Stop();
        Console.WriteLine("Thoi gian Phien ban A (N = " + o + "): " + stopwatchA.Elapsed.TotalMilliseconds + " ms");
        System.Diagnostics.Stopwatch stopwatchB = System.Diagnostics.Stopwatch.StartNew();
        PhienBanB(data);
        stopwatchB.Stop();
        Console.WriteLine("Thoi gian Phien ban B (N = " + o + "): " + stopwatchB.Elapsed.TotalMilliseconds + " ms");

        Console.ReadLine();
    }
    static int PhienBanA(int[] arr)
    {
        int maxTong = arr[0]; 
        for (int i = 0; i < arr.Length; i++) 
        {
            int tongHienTai = 0;
            for (int j = i; j < arr.Length; j++) 
            {
                tongHienTai = tongHienTai + arr[j]; 

                if (tongHienTai > maxTong)
                    maxTong = tongHienTai;
            }
        }
        return maxTong;
    }
    static int PhienBanB(int[] arr)
    {
        int maxTong = arr[0];     
        int tongHienTai = arr[0]; 

        for (int i = 1; i < arr.Length; i++)
        {
            if (tongHienTai < 0)
                tongHienTai = arr[i];
            else
                tongHienTai = tongHienTai + arr[i];
            if (tongHienTai > maxTong)
                maxTong = tongHienTai;
        }
        return maxTong;
    } 
    static int min (int a, int b, int c)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            return min;
        }
    static int max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
    static int tong(int a, int b, int c)
        {
            int tong = 0;
            tong = a + b + c;
            return tong;
        }
    static double trungbinh(int a, int b, int c)
        {
            double tbinh = 0;
            tbinh = (a + b + c) / 3.0;
            return tbinh;
        }
    static void duyetso(int[] arr)
        {
            int max1 = arr[0];
            int max2 = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;       
                    max1 = arr[i];     
                }
                else if (arr[i] < max1 && (arr[i] > max2))
                    max2 = arr[i];     
            }
            if (max2 == max1)
                Console.WriteLine("NO");
            else
                Console.WriteLine($"{max1} {max2}");
        }
   
}
