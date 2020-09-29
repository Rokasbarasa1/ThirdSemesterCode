using System;
using System.Collections.Generic;
using System.Text;

namespace Session2.EX2
{
    class Company
    {
        private List<Employee> employees = new List<Employee>();

        public Company()
        {
        }

        public double getMonthlySalaryTotal()
        {
            double salary = 0;
            foreach (var emp in employees)
            {
                salary += emp.GetMonthlySalary();
            }
            return salary;
        }

        public void EmployNewEmployee(Employee newEployee)
        {
            employees.Add(newEployee);
        }
    }
}
