using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class ContractEmployee : Employee
    {
        private string Id;
        public double HourlyPay { get; }
        public override string EmployeeId { get { return Id; } }
        public override double Salary()
        {
            return HourlyPay;
        }
        public ContractEmployee(string Id, string Name, double HourlyPay) : base(Name)
        {
            this.HourlyPay = HourlyPay;
            this.Id = Id;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
