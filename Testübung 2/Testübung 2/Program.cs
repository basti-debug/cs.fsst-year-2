using System;
using System.Collections.Generic;

namespace Testübung_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Pig());

            foreach(Animal a in animals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadKey();
        }
    }
}
