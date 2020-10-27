using System;

namespace Task3
{
    class Vehicle
    {
        private int _xCoordinate;
        private int _yCoordinate;
        private int _price;
        private int _speed;
        private int _year;
        private string _name;

        public Vehicle(int xCoordinate, int yCoordinate, int price, int speed, int year, string name)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Price = price;
            Speed = speed;
            Year = year;
            _name = name;
        }

        public int XCoordinate
        {
            get
            {
                return _xCoordinate;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("X can't be negative!");
                    _xCoordinate = 0;
                }
                else
                {
                    _xCoordinate = value;
                }
            }
        }
        public int YCoordinate
        {
            get
            {
                return _yCoordinate;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Y can't be negative!");
                    _xCoordinate = 0;
                }
                else
                {
                    _yCoordinate = value;
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            private set
            {
                while (value < 0)
                {
                    Console.WriteLine("Price can't be negative!");
                    _price = 0;
                }
                _price = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }
            private set
            {
                while (value < 0)
                {
                    Console.WriteLine("Speed can't be negative!");
                    _speed = 0;
                }
                _speed = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            private set
            {
                while (value < 0)
                {
                    Console.WriteLine("Year can't be negative!");
                    _year = 0;
                }
                _year = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "NoName";
                }
                else
                {
                    _name = value;
                }
            }
        }
    }
}
