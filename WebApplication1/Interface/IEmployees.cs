using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTWebAPI.Models;

namespace JWTWebAPI.Interface
{
    public interface IEmployees
    {
        public List<Employee> GetEmployeeDetails();
        public Employee GetEmployeeDetails(int id);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);
        public bool CheckEmployee(int id);
    }
}
