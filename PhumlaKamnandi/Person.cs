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
        private string Id,name,surname, phone, gender, email;
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

        //get and set methods for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //get and set methods for name
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        #endregion

        #region Constructor

        //default constructor
        public Person()
        {
            Id = "";
            name = "";
            surname = "";
            phone = "";
            gender = "";
            age = 0;
            email = "";
        }


        //parameterized constructor
        public Person(string ID, string name,string surname, string phone, string gender, int age, string email)
        {
            this.Id = ID;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.gender = gender;
            this.age = age;
            this.email = email; 
        }


        #endregion


        #region ToStringMethod
        public override string ToString()
        {
           //return the persons name and telephone number
            return name +" "+ surname+ '\n' + phone;
        }


        #endregion


    }
}
