using System;

namespace AlanHesabiEsas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil Seçin (Daire,Ucgen,Kare,Dikdortgen)");
            string sekilSecim = Console.ReadLine().ToLower();
            Sekil sekil = null;

            switch (sekilSecim)
            {
                case "daire":
                    Console.WriteLine("Yarıçap Girin:");
                    double yaricap = Convert.ToDouble(Console.ReadLine());
                    sekil = new Daire(yaricap);
                    break;
                case "ucgen":
                    Console.WriteLine("Kenar Uzunluğu Girin:");
                    double kenarUcgen = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Yükseklik Girin:");
                    double yukseklikUcgen = Convert.ToDouble(Console.ReadLine());
                    sekil = new Ucgen(kenarUcgen, yukseklikUcgen);
                    break;
                case "dikdortgen":
                    Console.WriteLine("Uzun Kenar Girin");
                    double uzunDik = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Kısa Kenar Girin");
                    double kisaDik = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Derinlik Girin");
                    double derinDik = Convert.ToDouble(Console.ReadLine());
                    sekil = new Dikdortgen(uzunDik, kisaDik, derinDik);
                    break;
                case "kare":
                    Console.WriteLine("Kenar Uzunkuğu Girin");
                    double kenarKare = Convert.ToDouble(Console.ReadLine());
                    sekil = new Kare(kenarKare);
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;

            }

            Console.WriteLine("Hesaplama Seçin (Alan,Hacim,Çevre)");
            string hesapSecim = Console.ReadLine().ToLower();
            Hesaplayici.Hesapla(sekil, hesapSecim);

        }
    }
}
