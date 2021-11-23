using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Übung.hiearchy
{
    internal class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        public override double Diameter()
        {
            return _radius * 2;
        }

        public override double Perimeter()
        {
            return Math.PI * this.Diameter();   
        }

        public override string ToString()
        {
            return String.Format("Circle with radius {0}, _radius");
        }
    }
}
