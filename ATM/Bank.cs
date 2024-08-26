using System;

namespace ATM
{
    public static class Bank
    {
        public static void startProcess()
        {
            Console.WriteLine("Yapılmak İstenen İşlemi Seçin: (1)ParaÇek, (2)ParaYatır, (3)BakiyeGöster, (4)ÖdemeYap");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    ParaCek();
                    break;
                case 2:
                    Console.WriteLine("Yatırılmak İstenen Miktarı Girin:");
                    int bakiye = Convert.ToInt32(Console.ReadLine());
                    ParaYatir(bakiye);
                    break;
                case 3:
                    BakiyeGoster();
                    break;
                case 4:
                    Console.WriteLine("Yatırılmak İstenen Miktarı Girin:");
                    int yatirilacak = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kurum Girin:");
                    string kurum = Console.ReadLine();
                    OdemeYap(yatirilacak, kurum);
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Yapıldı");
                    break;
            }
        }
        private static void ParaCek()
        {

        }
        private static void ParaYatir(int bakiye)
        {

        }
        private static void BakiyeGoster()
        {

        }
        private static void OdemeYap(int bakiye, string kurum)
        {

        }
    }
}