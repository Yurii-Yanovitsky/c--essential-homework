using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Show address info*****");
            Address address = new Address(123123, "Ukraine", "Kharkiv", "Molochna", 4, 150);
            address.ShowAddressInfo();

            Console.ReadKey();
        }
    }
}
