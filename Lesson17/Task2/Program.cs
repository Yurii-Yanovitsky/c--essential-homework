using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("BMW", "A1", 1998, "black"),
                new Car("Alfa Romeo", "AR", 2008, "blue"),
                new Car("Audi", "A8", 2010, "silver"),
                new Car("Bentley", "B5", 2015, "gray"),
                new Car("Bugatti", "BG", 2020, "white"),
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer("AR", "Yurii", "380994747875"),
                new Customer("A1", "Alex", "380974423432"),
                new Customer("BG", "Vlad", "380952132134"),
                new Customer("A8", "Nikolay", "380984354542"),
                new Customer("A8", "Vasya", "380664353215"),
            };

            var query = from car in cars
                        join customer in customers on car.Model equals customer.Model
                        select new {CustomerInfo = customer, PurchaseInfo = car };


            foreach (var customer in query)
            {
                Console.WriteLine(customer.CustomerInfo);
                Console.WriteLine(customer.PurchaseInfo);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
