using System;

namespace schoolprogramm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Name");


            p.setName("Name");
            p.getName();

            p.FirstName = "Name";
            string x = p.FirstName;
        }
    }
}