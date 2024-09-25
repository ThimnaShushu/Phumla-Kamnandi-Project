using System;

public class Booking
{
    private int BoooingID;
    //string Guest;
    private int roomNum;
    private DateTime bookingRange;
    private DateTime checkInDate;
    private DateTime checkOutDate;
    private string status;
    private int totalCost;


    public Booking(int BookingID, int roomNum, string status, int totalCost)
    {
        this.totalCost = totalCost;
        this.BoooingID = BookingID;
        this.roomNum = roomNum;
        this.status = status;


    }
}
