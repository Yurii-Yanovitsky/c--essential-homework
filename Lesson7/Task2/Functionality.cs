using System;

namespace Task2
{
    public static class Functionality
    {
        public static void SortByNUmber(Train[] trains)
        {

            for (int i = 0; i < trains.Length; i++)
            {

                for (int j = 0; j < trains.Length - 1; j++)
                {
                    if (trains[j].TrainNumber < trains[j++].TrainNumber)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            }
        }
        public static void ShowTrainInfo(Train train)
        {
            Console.WriteLine($"Name: {train.Name}");
            Console.WriteLine($"Destination: {train.Destination}");
            Console.WriteLine($"Number: {train.TrainNumber}");
            Console.WriteLine($"Departuer Time: {train.DepartureTime}");
        }

        public static void AddTrainInfo(Train[] trains)
        {

            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                name = string.IsNullOrEmpty(name) ? "No name specified!" : name;

                Console.Write("Destination: ");
                string destination = Console.ReadLine();
                destination = string.IsNullOrEmpty(destination) ? "No destination specified!" : destination;

                Console.Write("Number: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int n);
                int trainNumber = isNumber ? n : 0;

                Console.Write("Departuer Time: ");
                bool isDepartuerTime = DateTime.TryParse(Console.ReadLine(), out DateTime dateTime);
                DateTime departuerTime = isDepartuerTime ? dateTime : DateTime.MinValue;

                trains[i] = new Train(name, destination, trainNumber, departuerTime);
            }
        }
        public static void FindTrainbyNumber(Train[] trains, int trainNum)
        {

            bool isFound = false;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == trainNum)
                {
                    ShowTrainInfo(trains[i]);
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("There is no such train!");
            }
        }
    }
}
