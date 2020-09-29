using ExamExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamExercise.Services
{
    public class EmployeeService
    {
        public List<Employee> FilterEmployeesBasedOnOvertime(List<Employee> employees, bool hasOvertime)
        {
            List<Employee> filteredList = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if((employees[i].HoursPerMonth > 150) == hasOvertime)
                {
                    filteredList.Add(employees[i]);
                }
            }
            return filteredList;
        }

        public double GetTotalMonthlyExpense(List<Employee> employees)
        {
            double sum = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                sum += employees[i].GetMonthlyPay();
            }
            return sum;
        }
    }
}
