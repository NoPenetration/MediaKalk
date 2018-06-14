using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKalk
{
    public enum UsType { user, owner, admin  }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public UsType UsType { get; set; }
        public bool Status { get; set; }
        public ContactDetails ContactDetails { get; set; }

        public User()
        {

        }
        public User(string login, string name, string surname, string password, UsType usType, bool status, ContactDetails contactDetails):this()
        {
            Login = login;
            Name = name;
            Surname = surname;
            Password = password;
            UsType = usType;
            Status = status;
            ContactDetails = contactDetails;
        }
    }

    

}
