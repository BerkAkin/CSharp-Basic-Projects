using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kaldir("Algoritma", 22));
        }

        public static string Kaldir(string degisecek, int index)
        {
            if (degisecek.Length == 0)
            {
                Console.WriteLine("Değişecek Cümleyi Girmediniz");
                return "";
            }
            else
            {
                if (index > degisecek.Length)
                {
                    Console.WriteLine("Index cümle uzunluğunun dışında kalıyor");
                    return degisecek;
                }
                else
                {
                    return degisecek.Remove(index, 1).ToString();
                }
            }
        }
    }
}
