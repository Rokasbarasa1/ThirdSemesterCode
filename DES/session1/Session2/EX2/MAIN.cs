using System;
using System.Collections.Generic;
using System.Text;

namespace Session2.EX2
{
    class MAIN
    {
        static void Main(string[] args)
        {
            Company kaka = new Company();
            FullTimeEmployee ful = new FullTimeEmployee("rokas", 4, 9);
            PartTimeEmployee par = new PartTimeEmployee(19492, "fadgb");

            kaka.EmployNewEmployee(ful);
            kaka.EmployNewEmployee(par);

            Console.WriteLine(kaka.getMonthlySalaryTotal());
        }
    }
}
