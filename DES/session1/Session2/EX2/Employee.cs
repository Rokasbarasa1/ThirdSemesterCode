using System;
using System.Collections.Generic;
using System.Text;

namespace Session2.EX2
{

    abstract class Employee
    {
        private string name;

        protected Employee(string name)
        {
            this.name = name;
        }

        public virtual double GetMonthlySalary()
        {
            return 0;
        }

    }
}
