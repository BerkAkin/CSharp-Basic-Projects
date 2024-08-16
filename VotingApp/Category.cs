namespace VotingApp
{
    class Category
    {
        private double _percent;
        private string _name;
        private int _voteCount;
        public string Name { get => this._name; set => this._name = value; }
        public int VoteCount { get => this._voteCount; set => this._voteCount = value; }
        public double Percent { get => this._percent; set => this._percent = value; }

        public Category(string name, int count, double percent)
        {
            this._name = name;
            this._voteCount = count;
            this._percent = percent;
        }
    }
}