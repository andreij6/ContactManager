using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact.Models
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }

        public Address()
        {

        }

        public Address(string city, string street, string zip)
        {
            this.City = city;
            this.Street = street;
            this.Zip = zip;
        }
    }
}