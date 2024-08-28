using System;

namespace BarkodGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod Oluşturulacak URL Girin: ");
            string brk = Console.ReadLine();
            BarcodeOps.BarkodOlustur(brk);
        }
    }
}
