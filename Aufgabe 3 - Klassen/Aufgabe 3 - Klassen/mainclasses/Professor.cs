using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3___Klassen.mainclasses
{
    internal class Professor : Person
    {
        public string nicefullName()
        {
            if (sex == "men")
            {
                return ("Herr " + fullName());
            }
            else
                return ("Frau " + fullName());
        }

        
    }
}
