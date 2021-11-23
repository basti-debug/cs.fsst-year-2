using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolprogramm2
{
    internal class Person
    {
        private string _firstName;

        public Person(string firstName)
        {
            _firstName = firstName; 
        }

        public void setName(string firstName)
        {
            _firstName = firstName;
        }

        public string getName()
        {
            return _firstName;
        }

        public string FirstName
        {
            get { return _firstName; } 
            set { _firstName = value; }
        }
    }
}
