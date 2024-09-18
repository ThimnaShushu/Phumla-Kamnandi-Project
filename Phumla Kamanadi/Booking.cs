using System;

public class Booking
{
    int BoooingID;
    //string Guest;
    int roomNum;
    DateTime bookingRange;
    DateTime checkInDate;
    DateTime checkOutDate;
    string status;
    int totalCost;


    public Booking(int BookingID, int roomNum, string status, int totalCost)
	{
        this.totalCost = totalCost;
        this.BoooingID = BookingID;
        this.roomNum = roomNum;
        this.status = status;
        
        
	}
}
