using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3___Klassen.mainclasses
{
    internal class Person
    {
        public string sex;
        public string firstName;
        public string lastName;
        public DateTime birthday; 

        public string fullName()
        {
            return (firstName + " " + lastName);
        }

        public int age()
        {
            return (birthday.Year - DateTime.Now.Year); 
        }
    }
}
