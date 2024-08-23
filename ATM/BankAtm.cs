namespace ATM
{
    class BankAtm
    {
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