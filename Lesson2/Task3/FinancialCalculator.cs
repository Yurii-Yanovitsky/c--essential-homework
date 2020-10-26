namespace Task3
{
    public class FinancialCalculator
    {
        private readonly double _taxPercent;
        private readonly double _experienceCoefficient;

        public FinancialCalculator(double taxPercent, double expiriencePercent)
        {
            _taxPercent = taxPercent;
            _experienceCoefficient = expiriencePercent;
        }

        public double CalculateSalary(Employee emp)
        {

            return emp.Position.InitialSalary * emp.Position.SalaryKoef + emp.Position.InitialSalary * emp.WorkExperience * _experienceCoefficient;
        }
        public double CalculateTax(Employee emp)
        {
            return CalculateSalary(emp) * _taxPercent;
        }
    }
}
