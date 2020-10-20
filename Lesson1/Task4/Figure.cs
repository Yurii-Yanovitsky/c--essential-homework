using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Figure
    {
        private Point[] _points;
        private double _perimeter = 0;
        public string Name { get; }
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }

        public Figure(Point A, Point B, Point C, string name)
        {
            _points = new Point[] { A, B, C };
            Name = name;
            PerimiterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D, string name)
        {
            _points = new Point[] { A, B, C, D };
            Name = name;
            PerimiterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D, Point E, string name)
        {
            _points = new Point[] { A, B, C, D, E };
            Name = name;
            PerimiterCalculator();
        }

        public void PerimiterCalculator()
        {

            for (int i = 0; i < _points.Length; i++)
            {
                if (i + 1 == _points.Length)
                {
                    _perimeter += LengthSide(_points[0], _points[i]);
                }
                else
                {
                    _perimeter += LengthSide(_points[i], _points[i + 1]);
                }
            }
        }
        private double LengthSide(Point A, Point B)
        {
            double deltaX = A.X - B.X;
            double deltaY = A.Y - B.Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Perimeter: {Perimeter}\n");
        }
    }
}
