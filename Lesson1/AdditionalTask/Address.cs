using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    public class Address
    {
        int _index;
        string _country;
        string _city;
        string _street;
        int _house;
        int _apartment;

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _house = house;
            _apartment = apartment;
        }

        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        public int House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = value;
            }
        }

        public void ShowAddressInfo()
        {
            Console.WriteLine($"Index: {Index}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"House: {House}");
            Console.WriteLine($"Apartment: {Apartment}");
        }
    }
}
