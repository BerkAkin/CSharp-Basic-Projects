using System;

namespace VotingApp
{
    static class UserController
    {
        public static void Register(string username)
        {
            bool exist = Users.CheckIfExists(username.ToUpper());
            if (!exist)
            {
                Console.WriteLine("\nKullanıcı Bulunmadı. Kayıt işlemi başlatılıyor");
                ActionRegister();
            }
        }
        public static void ActionRegister()
        {
            Console.WriteLine("\nEnter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                User newUser = new User(username, password);
                Users.AddUser(newUser);
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Hata");
            }

        }
    }
}