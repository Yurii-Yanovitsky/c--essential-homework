namespace Task2
{
    class Customer
    {
        public string Model { get; }
        public string Name { get; }
        public string PhoneNumber { get; }

        public Customer(string model, string name, string phoneNumber)
        {
            Model = model;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {

            return $@"Name: {Name}
PhoneNumber: {PhoneNumber}";
        }
    }
}
