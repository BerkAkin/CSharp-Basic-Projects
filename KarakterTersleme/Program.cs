using System;

namespace KarakterTersleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çevrilecek Stringi Girin");
            string cevirilecek = Convert.ToString(Console.ReadLine());
            Console.WriteLine(TersCevir(cevirilecek));
        }

        public static string TersCevir(string cevirilecek)
        {
            char[] charArray = cevirilecek.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
