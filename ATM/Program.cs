using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAtm.userLogin();
            FileLogger.EndOfDay();
        }
    }
}
