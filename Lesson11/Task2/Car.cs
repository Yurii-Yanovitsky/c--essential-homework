namespace Task2
{
    public class Car
    {
        public string Name { get; }
        public string Year { get; }

        public Car(string name, string year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Year: {Year}";
        }
    }
}
