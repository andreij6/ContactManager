using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact.Models
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();


        public List<Person> Contacts = new List<Person>()
        {
            new Person(
                "281-509-1542", "Miguel", 
                "Guevara", 
                new Address("Houston", "2204 Wilson", "77047"), 
                "miguel@codercamps.com", 
                0),
           new Person(
                "281-555-1542", "Mike", 
                "Guevara", 
                new Address("Houston", "2105 Oak", "77047"), 
                "mike@codercamps.com", 
                1),
           new Person(
                "281-666-1542", "Bob", 
                "Guevara", 
                new Address("Houston", "2777 Kirby", "77047"), 
                "bob@codercamps.com", 
                2),


        };
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}