using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Point
    {
        private double _x;
        private double _y;
        private string _pointName;
        public double X
        {
            get
            {
                return _x;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
        }
        public string PointName { get; }
        public Point(double x, double y, string pointName)
        {
            _x = x;
            _y = y;
            _pointName = pointName;
        }
    }
}
