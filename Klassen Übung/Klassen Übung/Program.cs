using System;

namespace Klassen_Übung
{

    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("bmw", "1er", 150);
        }
    }
    class Car
    {
        private string brand;
        private string type;
        private int ps;

        public Car(string brand, string type, int ps)
        {
            this.brand = brand;
            this.ps = ps;   
        }

        public Car(string brand, string type, int ps)
        {
            this.brand = brand;
            this.type = type;
            this.ps = ps;
        }

    }
    
}
