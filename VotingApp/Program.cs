using System;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VoteController startProcess = new VoteController();
            startProcess.startVotingProcess();
        }
    }
}
