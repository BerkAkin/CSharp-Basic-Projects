using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    class Users
    {
        private static List<User> users = new List<User>{
            new User("BERK", "1234"),
            new User("AKIN", "1234"),
            new User("DENİZ", "1234"),
        };
        public static List<User> UserList { get => users; }
        public static void AddUser(User user)
        {
            UserList.Add(user);
        }

        public static bool CheckIfExists(string username)
        {
            return users.Any(x => x.Username == username);
        }
    }
}