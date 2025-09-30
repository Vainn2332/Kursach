using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Admin :User
    {
        public Admin() { }
        public Admin(string login, string password) : base(login, password) { }
        public override string GetData() => $"{Login}\t{Password}\tAdmin";
        
    }
}
