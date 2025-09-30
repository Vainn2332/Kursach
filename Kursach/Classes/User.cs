using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class User:IData
    {
        public string Login { get; }
        public string Password { get; }
        public User()
        {
            Login = "Udefined Login";
            Password = "Undefined Password";
        }
        public User(string login,string password)
        {
            Login = login;
            Password = password;
        }

        public virtual string GetData() => $"{Login}\t{Password}\tUser";
        
    }   
}
