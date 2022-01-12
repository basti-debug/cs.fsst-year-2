using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class student
    {
        string _name { get; set; }

        string _id { get; set; }

        public student(string Name, string ID)
        {
            _name = Name;
            _id = ID;
        }
    }
}
