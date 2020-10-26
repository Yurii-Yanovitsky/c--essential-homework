namespace Task3
{
    public class Employee
    {
        public Employee(string name, string lastName, Position position, int workExpirience)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            WorkExperience = workExpirience;
        }

        public string Name { get; }
        public string LastName { get; }
        public Position Position { get; }
        public int WorkExperience { get; set; }

        public double CalculateSalary(double taxPercent, double experienceCoefficient)
        {
            double salaryWithoutTax = Position.InitialSalary * Position.SalaryKoef + Position.InitialSalary * WorkExperience * experienceCoefficient;
            return salaryWithoutTax - salaryWithoutTax * taxPercent;
        }
    }
}
