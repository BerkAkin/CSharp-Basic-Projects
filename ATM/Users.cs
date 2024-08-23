using System.Collections.Generic;

namespace ATM
{
    public class Users
    {
        public List<User> Kullanicilar = new List<User>() {
            new User("Berk","Akın",1234),
            new User("Akın","Akın",1234),
        };
        private bool _loggedIn = false;
        private int _loggedInUserAccNum = 0;

        public void userLogin()
        {
            this._loggedIn = true;
            this._loggedInUserAccNum = 1;//kullanıcının hesap numarası bulunmalı öncelikle;
        }
        public void userLogout()
        {
            this._loggedIn = false;
            this._loggedInUserAccNum = 0;
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