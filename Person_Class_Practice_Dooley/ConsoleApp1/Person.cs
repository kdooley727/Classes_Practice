using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person

        //Person class Kyle Dooley 05/26/2022
    {
        public Person() { }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public void Introduction()
        {
            Console.WriteLine("Hello, my name is " + FirstName + " " + LastName);
        }

        public void DisplayContactInfo()
        {
            Console.WriteLine("Contact Info Address: {0}, Email: {1}", Address, Email);
        }
    }
}
