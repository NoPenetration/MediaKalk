using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKalk
{
    public enum PrType { house, flat, room, premises }
    class Property
    {

        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public PrType PrType { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string LocalNumber { get; set; }
        public int RoomNumber { get; set; }

        public Property()
        {

        }
        public Property(int ownerId, string name, PrType prType, string street, string homeNumber):this()
        {
            OwnerId = ownerId;
            Name = name;
            PrType = prType;
            Street = street;
            HomeNumber = homeNumber;
        }
        public Property(int ownerId, string name, PrType prType, string street, string homeNumber, int roomNumber) : this(ownerId, name, prType, street, homeNumber)
        {
            RoomNumber = roomNumber;
        }
        public Property(int ownerId, string name, PrType prType, string street, string homeNumber, string localNumber) : this(ownerId, name, prType, street, homeNumber)
        {
            LocalNumber = localNumber;
        }
        public Property(int ownerId, string name, PrType prType, string street, string homeNumber, string localNumber, int roomNumber) : this(ownerId, name, prType, street, homeNumber)
        {
            LocalNumber = localNumber;
            RoomNumber = roomNumber;
        }
    }
}
