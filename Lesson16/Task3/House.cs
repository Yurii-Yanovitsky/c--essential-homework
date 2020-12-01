namespace Task3
{
    class House
    {
        public House(string city, Street street)
        {
            City = city;
            Street = street;
        }

        public string City { get; set; }
        public Street Street { get; set; }

        public House Clone()
        {
            return new House(this.City, this.Street);
        }

        public House DeepClone()
        {
            return new House(this.City, (Street)this.Street.Clone());
        }

        public override string ToString()
        {
            return $"{City}, {Street.Name}";
        }
    }
}
