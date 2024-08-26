using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ATM
{
    class BankAtm
    {
        private bool _loggedIn = false;
        private int _loggedInUserAccNum = 0;

        //banka işlemleri başlamalı
        public void userLogin()
        {
            if (isLogged())
            {
                Console.WriteLine("Giriş Yapmış Bir Kullanıcı Zaten Mevcut Çıkış Yapmak İçin 1'e Basın");
                int option = Convert.ToInt32(Console.ReadKey());
                if (option == 1)
                {
                    userLogout();
                }
                else
                {
                    Console.WriteLine("Hatalı Bir Seçim Yaptınız. Sistem Kapatılıyor.");
                }

            }
            else
            {
                Console.WriteLine("Giriş Yap");
                Console.Write("Hesap Numarası: ");
                int accountNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Şifre: ");
                int password = Convert.ToInt32(Console.ReadLine());
                User user = Users.FindUser(accountNum, password);

                if (user != null)
                {
                    this._loggedIn = true;
                    this._loggedInUserAccNum = user.AccountNumber;
                    //burda banka işlemlerini başlatmak gerekiyor artık
                    Bank.startProcess();
                }
                else
                {
                    Console.WriteLine("Kullanıcı Bulunamadı");
                }

            }

        }

        public void userLogout()
        {
            this._loggedIn = false;
            this._loggedInUserAccNum = 0;
            Console.WriteLine("Başarıyla Çıkış Yapıldı.");
        }

        public bool isLogged()
        {
            if (this._loggedIn && this._loggedInUserAccNum > 0)
            {
                return true;
            }
            else
            {
                return false;
                //giriş işlemini yeniden yap ve sisteme log düş kullanıcı hatalı giriş yaptı diye
            }

        }
    }
}