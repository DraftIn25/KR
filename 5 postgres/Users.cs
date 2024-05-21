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
        static string password;
        static int minlength, maxlength;
        public string Login { get; set; }
        public string Role { get; }
        public string Password { get; set; }
       static  public bool Upper { get; set; }
          static  public bool Symbols { get; set; }
         static public int MinLength { get =>minlength; set=>minlength=value; }
           static  public int MaxLength { get => maxlength; set => maxlength = value; }
        public Users(string login,string role)
        {
            Login = login;
            Role=role;
        }
     static    public bool Pass(string text)
        {
            if (text.Length < minlength)
                return false;
            if (text.Length> maxlength)
                return false;
            if (!Upper && text.Any(Char.IsUpper))
                return false;
            if (!Symbols && text.IndexOfAny("!@#$%^&*()_+=|~/<>,.;:'{}[]".ToCharArray()) >= 0)
                return false;
            return true;
        }
    }
}
