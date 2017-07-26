using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPITest.Models;

namespace WebAPITest.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEnumerable<Employee> _empList;
        public EmployeeRepository()
        {
            if (_empList != null)
            {
                _empList = new[]
                {
                    new Employee {ID = 1, Name = "Nitesh", Experience = 4, Designation = "Soft. Engineer"},
                    new Employee {ID = 2, Name = "Deepak", Experience = 5, Designation = "Sr. Soft. Engineer"},
                    new Employee {ID = 3, Name = "Mohit", Experience = 3, Designation = "Soft. Engineer"},
                    new Employee {ID = 4, Name = "Prashant", Experience = 3, Designation = "Soft. Engineer"}
                };
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _empList;
        }

        public Employee GetEmployeeById(int id)
        {
            return _empList.FirstOrDefault(x => x.ID == id);
        }
    }
}