using ExamExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamExercise.Context
{
    public class DbRepository
    {
        private readonly EmployeeContext _context;

        public DbRepository(EmployeeContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.EmployeeList.ToList();
        }

        public void PostEmployee(Employee emp)
        {
            _context.Add(emp);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
