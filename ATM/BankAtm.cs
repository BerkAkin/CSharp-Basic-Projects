using System;
using System.Threading;

namespace ATM
{
    class BankAtm
    {
        private static bool _loggedIn = false;
        private static int _loggedInUserAccNum = 0;


        public static void userLogin()
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
                _loggedIn = true;
                _loggedInUserAccNum = user.AccountNumber;
                FileLogger.SetTransactionLogs("Kullanıcı Girişi Başarılı Oldu");
                Bank.startProcess(user);
            }
            else
            {
                Console.Clear();
                FileLogger.SetFraudLogs("Giriş Denemesi Hatalı Gerçekleşti");
                Console.WriteLine("Kullanıcı Bulunamadı");
                Thread.Sleep(3000);
                Console.Clear();

                userLogin();
            }



        }

        public static void userLogout()
        {
            _loggedIn = false;
            _loggedInUserAccNum = 0;
            Console.WriteLine("Başarıyla Çıkış Yapıldı.");
            FileLogger.SetTransactionLogs("Kullanıcı Çıkış Yaptı");
            userLogin();

        }

        public static bool isLogged()
        {
            if (_loggedIn && _loggedInUserAccNum > 0)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}