using System;

namespace AlanHesabı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalaması bulunmak istenen Fibonacci Basamak Sayısını Girin:");
            int basamak = Convert.ToInt32(Console.ReadLine());

            if (basamak <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin.");
                return;
            }

            int fiboToplam = 0;
            for (int i = 0; i < basamak; i++)
            {
                fiboToplam += Fibonacci(i);
            }

            Console.WriteLine("Fibonacci Toplamı: " + fiboToplam);
            Console.WriteLine("Bulunan Ortalama: " + ortalamaAl(basamak, fiboToplam));
            Console.ReadLine();
        }

        public static int Fibonacci(int basamak)
        {
            // 0 tabanlı rekürsif Fibonacci
            if (basamak <= 1) return basamak;
            return Fibonacci(basamak - 1) + Fibonacci(basamak - 2);
        }

        public static double ortalamaAl(int basamak, int fibo)
        {
            // Ortalama hesaplaması
            return (double)fibo / basamak;
        }
    }
}
