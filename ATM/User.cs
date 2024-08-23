using System;
namespace ATM
{
    public class User
    {
        private string _name;
        private string _surname;
        private int _accountNum;
        private int _password;
        private int _balance;
        public string Name { get => this._name; set => this._name = value; }
        public string Surname { get => this._surname; set => this._surname = value; }
        public int AccountNumber { get => this._accountNum; }
        public int Password { get => this._password; set => this._password = value; }
        public int Balance { get => this._balance; set => this._balance = value; }

        public User(string name, string surname, int Password)
        {
            this._name = name;
            this._surname = surname;
            this._accountNum = AccountNumCreator();
            this._password = Password;
            this._balance = 0;
        }

        public User(string name, string surname, int accountNumber, int Password)
        {
            this._name = name;
            this._surname = surname;
            this._accountNum = accountNumber;
            this._password = Password;
            this._balance = 0;
        }

        private int AccountNumCreator()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            return randomNumber;
        }

    }
}