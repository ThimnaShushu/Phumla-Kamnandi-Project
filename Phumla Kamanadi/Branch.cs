using System;

public class Branch
{
	string hotelID;
	string branchName;
	string location;
	string[] facilities;
	int numberOfRooms;
	double ratePerPerson;
	double ratePerRoom;

	public Branch(string hotelID, string branchName,string location,string[] facilities,int numberOfRooms,double ratePerPerson,double ratePerRoom)
	{
		this.hotelID = hotelID;
		this.branchName = branchName;
		this.location = location;
		this.ratePerPerson = ratePerPerson;
		this.ratePerRoom = ratePerRoom;
		this.numberOfRooms = numberOfRooms;
		
	}
}
