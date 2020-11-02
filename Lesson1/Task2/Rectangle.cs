using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            Initialize(side1, side2);
        }

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

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }

        private void Initialize(double side1, double side2)
        {
            if (side1 <= 0 || side2 <= 0)
            {
                _side1 = 0;
                _side2 = 0;
                Console.WriteLine("Side(s) cannot be negative or zero!");
            }
            else
            {
                _side1 = side1;
                _side2 = side2;
            }
        }
    }
}
