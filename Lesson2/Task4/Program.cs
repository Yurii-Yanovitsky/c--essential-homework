using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(324235, "Frank", "SKODA", 0.2)
            {
                Article = "Skoda Octavia",
                Quantity = 1,
                UnitCost = 11000,
            };

            invoice.CalculatePaymenAmount(true);
            invoice.CalculatePaymenAmount(false);

            Console.ReadKey();
        }
    }
}
