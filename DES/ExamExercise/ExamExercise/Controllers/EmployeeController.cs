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
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        private EmployeeService employeeService;
        public EmployeeController(EmployeeService employeeService, EmployeeContext _context)
        {
            this._context = _context;
            this.employeeService = employeeService;
            /*
            _context.EmployeeList.Add(new Employee { Name = "Rokas", HourlyWage = 1, HoursPerMonth = 1 });
            _context.SaveChanges();
            if (_context.EmployeeList.Count() == 0)
            {
                _context.EmployeeList.Add(new Employee { Name = "Rokas", HourlyWage = 1, HoursPerMonth = 1 });
                _context.SaveChanges();
            }
            */
        }

        [HttpGet]
        public async Task<List<Employee>> Get([FromQuery(Name = "hasOvertime")] bool overtime)
        {

            List<Employee> filteredList = employeeService.FilterEmployeesBasedOnOvertime(_context.EmployeeList.ToList(), overtime);
            return filteredList;
        }

        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            if (emp == null | !ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.EmployeeList.Add(emp);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}