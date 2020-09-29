using System;
using System.Collections.Generic;
using System.Text;

namespace Session2.EX2
{
    class FullTimeEmployee :Employee
    {
        private string name;
        private double hourlyWage;
        private int hoursPerMonth;

        public FullTimeEmployee(string name,double hourlyWage, int hoursPerMonth) : base(name)
        {
            this.name = name;
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthlySalary()
        {
            return hourlyWage * hoursPerMonth;
        }
    }
}
