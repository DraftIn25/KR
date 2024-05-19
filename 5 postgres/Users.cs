using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_postgres
{
    public class Users
    {
        public string Login { get; set; }
        public string Role { get; }
        public Users(string login,string role)
        {
            Login = login;
            Role=role;
        }
    }
}
