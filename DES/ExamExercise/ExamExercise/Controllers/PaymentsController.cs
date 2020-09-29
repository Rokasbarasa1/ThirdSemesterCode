using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamExercise.Context;
using ExamExercise.Model;
using ExamExercise.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private EmployeeContext _context;
        private EmployeeService employeeService;
        public PaymentsController(EmployeeService employeeService, EmployeeContext _context)
        {
            this._context = _context;
            this.employeeService = employeeService;

            if (_context.EmployeeList.Count() == 0)
            {
                _context.EmployeeList.Add(new Employee { Name = "Rokas" , HourlyWage = 1, HoursPerMonth = 1});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<double> Get()
        {
            double sum = employeeService.GetTotalMonthlyExpense(_context.EmployeeList.ToList());
            return sum;
        }
    }
}