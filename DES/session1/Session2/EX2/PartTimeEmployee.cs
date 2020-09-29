using System;
using System.Collections.Generic;
using System.Text;

namespace Session2.EX2
{
    class PartTimeEmployee : Employee
    {
        private double monthlySalary;
        private string name;

        public PartTimeEmployee(double monthlySalary, string name) : base(name)
        {
            this.monthlySalary = monthlySalary;
            this.name = name;
        }

        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}
