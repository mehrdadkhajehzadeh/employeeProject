using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int employeeID, int salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"name is : {Name}, EmployeeId is : {EmployeeID}, salary is : {Salary}");
        }
    }
}
