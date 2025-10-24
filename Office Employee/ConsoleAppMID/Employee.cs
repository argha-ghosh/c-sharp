using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMID
{
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(int employeeId, string name, string department, decimal baseSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            Department = department;
            BaseSalary = baseSalary;
        }

        public abstract void ShowInfo();
        public abstract void SalaryDetails();
        public abstract bool CheckPromotionEligibility();
    }

}
