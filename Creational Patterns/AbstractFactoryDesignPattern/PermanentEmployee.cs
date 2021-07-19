namespace Learn
{
    public class PermanentEmployee : Employee
    {
        private string Id;
        public double MonthlySalary { get; }
        public override string EmployeeId { get { return "TMP" + Id; } }
        //override to provide Monthly Salary
        public override double Salary()
        {
            return MonthlySalary;
        }
        public PermanentEmployee(string Id, string Name, double MonthlySalary) : base(Name)
        {
            this.MonthlySalary = MonthlySalary;
            this.Id = Id;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override double MedicalCoverage()
        {
            return 20;
        }
    }
}
