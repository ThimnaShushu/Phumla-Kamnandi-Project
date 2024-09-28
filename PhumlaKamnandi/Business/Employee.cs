using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Employee : Person
    {
        #region data members
        String employeeID;

        String role;


        #endregion





        #region Property methods
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }


        #endregion


        #region Constructor
       public  Employee(string ID, string name, string surname, string phone, string gender, int age,String role)
        {
         // base(ID, name, surname, phone, gender, age);
            this.role = role;


        }

        #endregion




    }
}
