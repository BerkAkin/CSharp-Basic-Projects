namespace ATM
{
    public class Log
    {
        private string _date;
        private string _message;

        public string Message { get; set; }
        public string Date { get; set; }
        public Log(string date, string message)
        {
            this.Date = date;
            this.Message = message;
        }
    }
}