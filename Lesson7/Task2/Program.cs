using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the required number of trains: ");

            bool isMoreThanOne = int.TryParse(Console.ReadLine(), out int number);
            number = isMoreThanOne ? number : 1;

            Train[] trains = new Train[number];

            Functionality.AddTrainInfo(trains);
            Functionality.SortByNUmber(trains);

            Console.WriteLine("Enter a train number to find: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int trainNum);
            trainNum = isNumber ? trainNum : 0;

            Functionality.FindTrainbyNumber(trains, trainNum);

            Console.ReadLine();
        }
    }
}