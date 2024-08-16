namespace VotingApp
{
    class User
    {
        private bool _voteStatus;
        private string _username;
        private string _password;
        public bool VoteStatus { get => this._voteStatus; set => this._voteStatus = value; }
        public string Username { get => this._username; set => this._username = value; }
        public string Password { get => this._password; set => this._password = value; }

        public User(string username, string password, bool votestatus)
        {
            this._username = username;
            this._password = password;
            this._voteStatus = votestatus;
        }
    }
}