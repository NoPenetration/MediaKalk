using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaKalk;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactDetails cd = new ContactDetails(123123123, "email", "city", "street", "20D");
            User a = new User("login", "name", "surname", "password", MediaKalk.Type.user,false, cd);
            Console.ReadKey();
        }
    }
}
