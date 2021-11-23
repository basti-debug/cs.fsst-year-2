using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Übung.hiearchy
{
    internal class Square : Shape
    {
        private double _x;
        public Square(double x)
        {
            _x = x;
        }

        public override double Area()
        {
            return _a * _b;
        }

        public override double Perimeter()
        {
            return 2 * _a + 2 * _b;
        }

        public override string ToString()
        {
            return String.Format("Rectangle by {0} x {1}", _a, _b);
        }


    }
}
