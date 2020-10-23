namespace Task3
{
    public class FinancialCalculator
    {
        private readonly decimal _taxPercent;
        private readonly decimal _expiriencePercent;

        public FinancialCalculator(decimal taxPercent, decimal expiriencePercent)
        {
            _taxPercent = taxPercent;
            _expiriencePercent = expiriencePercent;
        }

        public decimal CalculateSalary(Employee emp)
        {

            return emp.Position.InitialSalary * emp.Position.SalaryKoef + emp.Position.InitialSalary * emp.WorkExperience * _expiriencePercent;
        }
        public decimal CalculateTax(Employee emp)
        {
            return CalculateSalary(emp) * _taxPercent;
        }
    }
}
