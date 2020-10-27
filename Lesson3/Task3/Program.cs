using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 0, 11000, 90, 2011, "MyCar");
            Ship ship = new Ship(40, 120, 2000000, 80, 2016, "Odessa", 200, "MyShip");
            Plane plane = new Plane(0, 0, 35000000, 700, 2018, 4000, 5, "MyPlane");

            ShowVehicleInfo(car);
            ShowVehicleInfo(ship);
            ShowVehicleInfo(plane);

            Console.ReadKey();
        }
        static void ShowVehicleInfo(Vehicle vehicle)
        {
            Console.WriteLine($"Name: {vehicle.Name}");
            Console.WriteLine($"Location: {vehicle.XCoordinate}, {vehicle.YCoordinate}");
            Console.WriteLine($"Price: {vehicle.Price}$");
            Console.WriteLine($"Speed: {vehicle.Speed}MPH");
            Console.WriteLine($"Year: {vehicle.Year}");

            if (vehicle is Ship ship)
            {
                Console.WriteLine($"Port: {ship.Port}");
                Console.WriteLine($"Passangers: {ship.Passangers}");
            }
            else if(vehicle is Plane plane)
            {
                Console.WriteLine($"Height: {plane.Height}m");
                Console.WriteLine($"Passangers: {plane.Passangers}");
            }
            Console.WriteLine();
        }
    }
}
