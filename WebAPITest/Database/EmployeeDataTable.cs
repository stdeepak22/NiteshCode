﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPITest.Models;

namespace WebAPITest.Database
{
    public class EmployeeDataTable : IDataTable<Employee>
    {
        public IEnumerable<Employee> Data { get{return _data;}}


        private static List<Employee> _data = null;
        static EmployeeDataTable()
        {
            _data = new List<Employee>
            {
                new Employee {ID = 1, Name = "Nitesh", Experience = 4, Designation = "Soft. Engineer"},
                new Employee {ID = 2, Name = "Deepak", Experience = 5, Designation = "Sr. Soft. Engineer"},
                new Employee {ID = 3, Name = "Mohit", Experience = 3, Designation = "Soft. Engineer"},
                new Employee {ID = 4, Name = "Prashant", Experience = 3, Designation = "Soft. Engineer"}
            };
        }

        public Employee Add(Employee obj)
        {
            obj.ID = _data.Max(c => c.ID) + 1;
            _data.Add(obj);
            return obj;
        }
        
    }
}