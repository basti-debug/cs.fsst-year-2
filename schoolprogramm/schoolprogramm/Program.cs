using System;

namespace schoolprogramm 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Number: {0}, Word: {1}", 2, "hi");

            int y = 2;
            Foo x = new Foo();

            y.ToString();
            x.ToString();   
        }            
    }

    class Foo
    {
        public override string ToString()
        {
            return "Foo Override String";
        }
    }
}