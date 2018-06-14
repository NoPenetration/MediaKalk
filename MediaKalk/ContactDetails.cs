using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKalk
{
    public class ContactDetails
    {
        public uint PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }


        public ContactDetails(uint phoneNumber, string email, string city, string street, string homeNumber)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            City = city;
            Street = street;
            HomeNumber = homeNumber;
        }
    }
}
