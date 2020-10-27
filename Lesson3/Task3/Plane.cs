using System;

namespace Task3
{
    class Plane : Vehicle
    {
        private int _height;
        private int _passangers;

        public Plane(int xCoordinate, int yCoordinate, int price, int speed, int year, int height, int passangers, string name)
            : base(xCoordinate, yCoordinate, price, speed, year, name)
        {
            Height = height;
            Passangers = passangers;
        }

        public int Height
        {
            get
            {
                return _height;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Number of passengers can't be negative!");
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }
        public int Passangers
        {
            get
            {
                return _passangers;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Number of passengers can't be negative!");
                    _passangers = 0;
                }
                else
                {
                    _passangers = value;
                }
            }
        }
    }
}
