using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    public static class Users
    {
        public static List<User> Kullanicilar = new List<User>() {
            new User("Berk","Akın",1111,1234),
            new User("Cem","Karaca",1234),
        };

        public static User FindUser(int accountNum, int Password)
        {
            return Kullanicilar.FirstOrDefault(user => user.AccountNumber == accountNum && user.Password == Password);
        }

    }


}