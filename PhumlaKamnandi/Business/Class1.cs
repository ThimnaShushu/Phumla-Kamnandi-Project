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

        public enum RoleType
        {
            /*The role ID will be stored as an enumeration type. 
             So an employee can either have no role, that is, not yet assigned (0), be a Headwaiter (1), a Waiter (2) 
             or a Runner (3). Once you declare the role type as an enumeration type, make sure the role ID (roleval) 
             is of this type (RoleType).  */
            Receptionist  = 0,
            Administrator = 1,
            Manager = 2,
            Runner = 3
        }


        #endregion





        #region Property methods
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }


        #endregion




    }
}
