namespace VotingApp
{
    class User
    {
        private int _id;
        private string _username;
        private string _password;
        public int Id { get => this._id; set => this._id = value; }
        public string Username { get => this._username; set => this._username = value; }
        public string Password { get => this._password; set => this._password = value; }

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
        }
    }
}