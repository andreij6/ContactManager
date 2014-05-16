using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }

        public Person(string phone, string firstName, string lastName, Address add, string email, int id)
        {
            this.ID = id;
            this.PhoneNumber = phone;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = add;
            this.Email = email;
        }
    }
}