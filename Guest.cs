using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi
{
    public class Guest
    {
        // Properties
        public int GuestId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; } 
        public Room AssignedRoom { get; set; } 

        // Constructor
        public Guest(int guestId, string fullName, string address, string phoneNumber, string email, string creditCardNumber)
        {
            GuestId = guestId;
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            CreditCardNumber = creditCardNumber;
            AssignedRoom = null; // Initially, no room is assigned
        }

        // Method to update guest information
        public void UpdateInformation(string address, string phoneNumber, string email)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Method to verify credit card (simplified for demonstration purposes)
        public bool VerifyCreditCard(string creditCardNumber)
        {
            // In a real system, this would involve interaction with a payment gateway
            return CreditCardNumber == creditCardNumber;
        }

        // Method to assign a room to the guest
        public void AssignRoom(Room room)
        {
            AssignedRoom = room;
        }

        // Method to release the room assignment
        public void ReleaseRoom()
        {
            AssignedRoom = null;
        }
    }

}
