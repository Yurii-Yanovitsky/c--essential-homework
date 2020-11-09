using System;

namespace Task2
{
    public struct Train
    {
        public Train(string name, string destination, int trainNumber, DateTime departuerTime)
        {
            Name = name;
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departuerTime;
        }

        public string Name { get; }
        public string Destination { get; }
        public int TrainNumber { get; }
        public DateTime DepartureTime { get; }
    }
}