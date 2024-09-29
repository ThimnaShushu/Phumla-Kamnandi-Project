using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using Phumla_Kamnandi;

using System;
using System.Collections.Generic;
using System.Linq;

namespace PhumlaKamnandiHotel
{
    public class GuestController
    {
        private List<Guest> theGuest;

        // Constructor
        public GuestController()
        {
            theGuest = new List<Guest>();
        }

        // Method to Add a New Guest
        public void AddGuest(Guest newGuest)
        {
            if (theGuest.Exists(g => g.GuestId == newGuest.GuestId))
            {
                throw new Exception("Guest with this ID already exists.");
            }

            theGuest.Add(newGuest);
        }


        // Method to Find Guest by ID
        public Guest FindGuestByID(int guestID)
        {
            return theGuest.FirstOrDefault(g => g.GuestId == guestID);
        }

        // Method to Update Guest Information
        public void UpdateGuest(Guest updatedGuest)
        {
            var existingGuest = FindGuestByID(updatedGuest.GuestId);
            if (existingGuest == null)
            {
                throw new Exception("Guest not found.");
            }

            existingGuest.FullName = updatedGuest.FullName;
           
            existingGuest.Address = updatedGuest.Address;
            existingGuest.PhoneNumber = updatedGuest.PhoneNumber;
        }

        // Method to Delete a Guest
        public void DeleteGuest(int guestID)
        {
            var guestToRemove = FindGuestByID(guestID);
            if (guestToRemove == null)
            {
                throw new Exception("Guest not found.");
            }

            theGuest.Remove(guestToRemove);
        }
    }
}
