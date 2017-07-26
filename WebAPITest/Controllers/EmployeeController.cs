﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPITest.Models;
using WebAPITest.Services;

namespace WebAPITest.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public IEnumerable<Employee> Get()
        {
            return _employeeManager.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeManager.GetEmployeeById(id);
        }

        public Employee PostEmployee(Employee employee)
        {
            return _employeeManager.VerifyAndSave(employee);
        }
    }
}