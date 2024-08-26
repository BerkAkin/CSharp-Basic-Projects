using System;
using System.IO;

namespace ATM
{
    public static class Bank
    {
        public static void startProcess(User user)
        {
            Console.WriteLine("Yapılmak İstenen İşlemi Seçin: (1)ParaÇek, (2)ParaYatır, (3)BakiyeGöster, (4)ÖdemeYap (5)GünSonu");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    ParaCek(user);
                    break;
                case 2:
                    Console.WriteLine("Yatırılmak İstenen Miktarı Girin:");
                    int bakiye = Convert.ToInt32(Console.ReadLine());
                    ParaYatir(user, bakiye);
                    break;
                case 3:
                    BakiyeGoster(user);
                    break;
                case 4:
                    Console.WriteLine("Yatırılmak İstenen Miktarı Girin:");
                    int yatirilacak = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kurum Girin:");
                    string kurum = Console.ReadLine();
                    OdemeYap(user, yatirilacak, kurum);
                    break;
                case 5:
                    Console.WriteLine("Gün Sonu Gösteriliyor");
                    FileLogger.EndOfDay();
                    Console.WriteLine("Gün Sonu Log Dosyası Masaüstüne Kaydedildi");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Yapıldı");
                    break;
            }
        }
        private static void ParaCek(User user)
        {
            Console.WriteLine("Bakiyeniz: " + user.Balance);
            Console.Write("Çekmek İstediğiniz Miktar: ");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            user.Balance -= bakiye;
            Console.WriteLine("Para Çekme İşlemi Başarılı. Yeni Bakiyeniz " + user.Balance);
            FileLogger.SetTransactionLogs(user.Name + " " + user.Surname + bakiye + " Kadar Para Çekti");
        }
        private static void ParaYatir(User user, int bakiye)
        {
            Console.WriteLine("Mevcut Bakiyeniz: " + user.Balance);
            user.Balance += bakiye;
            Console.WriteLine("Para Yatırma İşlemi Başarılı. Yeni Bakiyeniz: " + user.Balance);
            FileLogger.SetTransactionLogs(user.Name + " " + user.Surname + bakiye + " Kadar Para Yatırdı");

        }
        private static void BakiyeGoster(User user)
        {
            Console.WriteLine("Mevcut Bakiyeniz: " + user.Balance);
            FileLogger.SetTransactionLogs(user.Name + " " + user.Surname + " Bakiyesini Kontrol Etti");
        }
        private static void OdemeYap(User user, int bakiye, string kurum)
        {
            Console.WriteLine(bakiye + " " + kurum + " 'a yatırılıyor");
            user.Balance -= bakiye;
            Console.WriteLine("Ödeme İşlemi Başarılı");
            Console.Write(" Mevcut Bakiyeniz: " + user.Balance);
            FileLogger.SetTransactionLogs(user.Name + " " + user.Surname + " " + kurum + "'a" + bakiye + " Kadar Ödeme Yaptı");
        }
    }
}