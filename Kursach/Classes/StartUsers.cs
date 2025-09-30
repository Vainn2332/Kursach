using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class StartUsers:User
    {
        private List<User> startUsers = new List<User>();
        public StartUsers()
        {
            startUsers.Add(new Admin("Vlad","123"));
            startUsers.Add(new User("User","111"));
        }
        public List<User> GetStartUsers()
        {
            return startUsers;
        }
    }
}
