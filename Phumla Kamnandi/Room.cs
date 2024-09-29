using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi
{
    public class Room
    {
        // Properties of the Room
        public int RoomNumber { get; set; }
        
        public bool IsAvailable { get; set; }
        
        public double RatePerPerson { get; set; }
        public bool IsRoomAllocated { get; set; }
        public List<string> Guests { get; set; }
        public RoomTariffType TariffType { get; set; }
        public bool HasBarFridge { get; set; }
        // Constructor
        public Room(int roomNumber, int numberOfBeds, bool hasEnSuite, double ratePerPerson, RoomTariffType tariffType, bool hasBarFridge)
        {
            
            RatePerPerson = ratePerPerson;
            IsAvailable = true;
            IsRoomAllocated = false;
            Guests = new List<string>();
            TariffType = tariffType;
            HasBarFridge = hasBarFridge;
        }
        // Method to allocate room to guests
        public void AllocateRoom(List<string> guests)
        {
            if (guests.Count <= 4) // No more than 4 people allowed in a room
            {
                IsAvailable = false;
                IsRoomAllocated = true;
                Guests = guests;
            }
            else
            {
                throw new Exception("No more than 4 people are allowed to stay in a room.");
            }
        }
        // Method to free the room
        public void FreeRoom()
        {
            IsAvailable = true;
            IsRoomAllocated = false;
            Guests.Clear();
        }
        // Method to calculate the rate based on number of guests and tariff type
        public double CalculateRate(int numberOfGuests)
        {
            if (TariffType == RoomTariffType.PerPerson)
            {
                return numberOfGuests * RatePerPerson;
            }
            else if (TariffType == RoomTariffType.PerRoom)
            {
                return RatePerPerson; // Flat rate for the entire room
            }
            else
            {
                throw new Exception("Invalid tariff type.");
            }
        }
   
    }
    // Enum for the Room Tariff Type
    public enum RoomTariffType
    {
        PerPerson,
        PerRoom
    }
}
