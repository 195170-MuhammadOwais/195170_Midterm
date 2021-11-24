using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _195170_Midterm.model
{
    public class EmployeeViewModel
    {
        public HashSet<Employee> Employees { get; set; }
        public EmployeeViewModel()
        {
            Employees = new HashSet<Employee>();
            Employees.Add(new Employee
            {
                EmployeeID = 1, FirstName = "Muhammad", LastName = "Khan", DOB = new DateTime(2000, 11, 20), Salary = 500000
            });
            Employees.Add(new Employee
            {
                EmployeeID = 2, FirstName = "Osama", LastName = "Laden", DOB = new DateTime(1999, 12, 15), Salary = 300000
            });
        }
    }
}
