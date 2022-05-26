using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikMashLib
{
    public class User
    {
        private string userName;
        private string password;

        public User() { }

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public static List<User> CreateUsersList()
        {
            List<User> users = new List<User>();

            users.Add(new User("admin", "admin"));
            users.Add(new User("Roche", "1234"));
            users.Add(new User("Lucien", "1234"));
            users.Add(new User("Herman", "P123"));

            return users;

        }
    }
}
