using System;
namespace Learn
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public abstract string EmployeeId { get; }

        public abstract double Salary();
        public virtual double MedicalCoverage()
        {
            return 200000;
        }
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"Name={Name} ,Id={EmployeeId},Salary={Salary()},Medical Allowance={MedicalCoverage()}";
        }
    }
      
    
}