using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Aspire 5", "Acer", 15000);
            laptop.ShowInfo();

            Console.ReadLine();
        }
    }
    struct Laptop
    {
        public string Model { get; }
        public string Manufacturer { get; }
        public double Price { get; }

        public Laptop(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Price: {Price}UAH");
        }
    }
}
