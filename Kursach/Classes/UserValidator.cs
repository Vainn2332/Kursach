using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class UserValidator
    {
        public bool CheckValidation(User user)
        {
            if(string.IsNullOrEmpty(user.Login)||string.IsNullOrEmpty(user.Password)) 
                return false; 

            foreach (char ch in user.Login)
            {
                if (!char.IsLetterOrDigit(ch)||string.IsNullOrEmpty(ch.ToString()))
                    return false;
            }
            foreach (char ch in user.Password)
            {
                if (!char.IsLetterOrDigit(ch) || string.IsNullOrEmpty(ch.ToString()))
                    return false;
            }
            return true;
        }
    }
}
