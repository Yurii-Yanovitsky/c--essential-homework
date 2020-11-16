using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> park = new CarCollection<Car>();

            Console.WriteLine($"Capacity: {park.Capacity}");

            park.Add(new Car("BMW", "2005"));
            park.Add(new Car("FORD", "2010"));
            park.Add(new Car("SKODA", "2015"));
            park.Add(new Car("PORSHE", "2018"));
            park.Add(new Car("AUDI", "2020"));

            foreach (var car in park)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine($"Number of cars: {park.Count}");

            Console.WriteLine($"\n{park[4]}\n");

            park.ClearPark();
            Console.WriteLine("Clearing is done!");
            Console.WriteLine($"Number of cars: {park.Count}");

            Console.ReadLine();
        }
    }
}
