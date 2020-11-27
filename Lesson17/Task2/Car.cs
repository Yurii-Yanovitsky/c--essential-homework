namespace Task2
{
    class Car
    {
        public string Mark { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }

        public Car(string mark, string model, int year, string color)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {

            return $@"Mark: {Mark}
Model: {Model}
Year: {Year}
Color: {Color}";
        }
    }
}
