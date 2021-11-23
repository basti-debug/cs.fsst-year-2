using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new list<Shape>();

            shapes.Add(new Rectangle(3, 2));
            shapes.Add(new Square(5));
            shapes.Add(new Circle(8));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("{0} has the area of {1}", shape.ToString(), shape.Area());
            }
        }
    }
}