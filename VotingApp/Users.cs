using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    class Users
    {
        private static List<User> users = new List<User>{
            new User("BERK", "1234", false),
            new User("AKIN", "1234", false),
            new User("DENİZ", "1234", false),
        };
        public static List<User> UserList { get => users; set => users = value; }
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