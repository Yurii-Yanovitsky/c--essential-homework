using System;

namespace Task3
{
    class Ship : Vehicle
    {
        private string _port;
        private int _passangers;

        public Ship(int xCoordinate, int yCoordinate, int price, int speed, int year, string port, int passangers, string name)
            : base(xCoordinate, yCoordinate, price, speed, year, name)
        {
            Port = port;
            Passangers = passangers;
        }

        public string Port
        {
            get
            {
                if (string.IsNullOrEmpty(_port))
                {
                    return "Not specified!";
                }
                else
                {
                    return _port;
                }
            }
            private set
            {
                _port = value;
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
