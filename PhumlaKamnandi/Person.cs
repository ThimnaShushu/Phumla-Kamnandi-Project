using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhumlaKamnandi
{
    public class Person
    {
        #region Data Members
        private string Id, fullName, phone, gender;
        private int age;

        public enum Type
        {
            Customer = 0,
            Guest = 1,
            Employee=2
        }

        #endregion

        #region Properties

        //get and set methods for ID
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        //get and set methods for full name
        public string Name
        {
            get { return fullName; }
            set { fullName = value; }
        }

        //get and set methods for telephone number
        public string Telephone
        {
            get { return phone; }
            set { phone = value; }

        }


        //get and set methods for gender
        public string Gender
        {
            get { return gender; }
            set { gender = value; }

        }

        //get and set methods for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        } 


        #endregion

        #region Constructor

        //default constructor
        public Person()
        {
            Id = "";
            fullName = "";
            phone = "";
            gender = "";
            age = 0;
        }

        //parameterized constructor
        public Person(string ID, string name, string phone, string gender, int age)
        {
            this.Id = ID;
            this.fullName = name;
            this.phone = phone;
            this.gender = gender;
            this.age = age;
        }


        #endregion


        #region ToStringMethod
        public override string ToString()
        {
           //return the persons name and telephone number
            return fullName + '\n' + phone;
        }


        #endregion


    }
}
