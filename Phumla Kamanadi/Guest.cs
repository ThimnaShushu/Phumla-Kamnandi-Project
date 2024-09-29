using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_INF2011S_Project
{  #region Data Members
    public class Guest
    //string Guest 
    // inherit name and person from Liya 
    { private int guestID;
    private string firstName;
    private string surname;
    private string email;
    private string address;
    private int phoneNumber;
#endregion
#region Constructors 
    public Guest(int guestID, string firstName, string surname, string email, string address, int phoneNumber)
    {
        this.guestID = guestID;
        this.firstName = firstName;
        this.surname = surname;
        this.email = email;
        this.address = address;
        this.phoneNumber = phoneNumber;
    }
    # region Property Methods 
    public string GuestID 
    {
        get {return guestID;}
        set {guestID = value;}
    }
    public string Address 
    {
        get {return address;}
        set{address = value;}
    }
    public string PhoneNumber
    {
        get {return phoneNumber;}
        set {phoneNumber = value;}
    }
    public string Email 
    {
        get{return email;}
        set{email = value;}
    }
    public string FirstName 
    {
        get{return firstName;}
        set{firstName = value;}
    }
    public string Surname 
    {
        get{return surname;}
        set{ surname = value;}
    }
    #endregion
    #region  ToString Method 
    public override string ToString()
    


    
        
     
        

    
    
    




    
}
