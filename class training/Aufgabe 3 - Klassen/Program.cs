using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3___Klassen
{
   
    public class person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hey my name is " + Name + " and iam " + Age + " years old");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person gustav = new person();
            gustav.Name = "Gustav";
            gustav.Age = 12;
            gustav.HasPet = true;

            gustav.Greeting();

            Console.ReadKey();
        }
    }

}
