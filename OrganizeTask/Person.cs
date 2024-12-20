using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizeTask
{
    public class Person
    {
        private string firstName = null;
        private string lastName = null;
        private string email = null;
        private string phone = null;

        public Guid? ID
        {
            get;
            set;
        }

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set 
            {
                if (value == null)
                    this.email = "";
                else this.email = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set 
            { 
                if (value == null)
                    this.phone = "";
                else this.phone = value;
            }
        }

        public Person() 
        {
            ID = Guid.NewGuid();
        }

        public Person(string firstName, string lastName, string email, string phone)
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return FirstName;
        }
    }
}
