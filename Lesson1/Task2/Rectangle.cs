using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        double _side1;
        double _side2;
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }
        public Rectangle()
        {

        }
        public double AreaCalculator()
        {
            return _side1 * _side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }
}
