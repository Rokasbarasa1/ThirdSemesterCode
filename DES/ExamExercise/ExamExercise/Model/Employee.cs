using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamExercise.Model
{
    public class Employee
    {

        public string Name { get; set; }
        public double HourlyWage { get; set; }
        public double HoursPerMonth { get; set; }

        public double GetMonthlyPay()
        {
            if(HoursPerMonth > 150)
            {
                double overtime = HoursPerMonth - 150;
                return HourlyWage * HoursPerMonth + HourlyWage * overtime * 1.5;
            }
            else
            {
                return HourlyWage * HoursPerMonth;
            }
        }

        
    }
}
