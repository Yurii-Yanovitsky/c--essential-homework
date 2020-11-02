using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(324235, "Frank", "SKODA", "Skoda Octavia", 1, 11000, 0.2);

            invoice.CalculatePaymenAmount(true);
            invoice.CalculatePaymenAmount(false);

            Console.ReadKey();
        }
    }
}
