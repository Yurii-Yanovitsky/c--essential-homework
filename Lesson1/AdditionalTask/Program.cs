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
            Console.WriteLine("*****Show address info*****");
            Address address = new Address(123123, "Ukraine", "Kharkiv", "Molochna", 4, 150);
            address.ShowAddressInfo();

            Console.ReadKey();
        }
    }
}
