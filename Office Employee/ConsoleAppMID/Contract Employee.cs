using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppMID
{
    class ContractEmployee : Employee
    {
        public int ContractDuration { get; set; } // in months
        public string ProjectName { get; set; }

        public ContractEmployee(int employeeId, string name, string department, decimal baseSalary, int contractDuration, string projectName)
            : base(employeeId, name, department, baseSalary)
        {
            ContractDuration = contractDuration;
            ProjectName = projectName;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Contract] ID: {EmployeeId}, Name: {Name}, Department: {Department}, Project: {ProjectName}");
        }

        public override void SalaryDetails()
        {
            Console.WriteLine($"Base Salary: {BaseSalary}, Contract Duration: {ContractDuration} months");
        }

        public override bool CheckPromotionEligibility()
        {
            return ContractDuration > 12;
        }
    }

}

/*A factory wants to track employee shifts.There are three types of workers: FullTimeEmployee, PartTimeEmployee, and ContractEmployee.
 * All employees have employeeId, name, department, and baseSalary.
• FullTimeEmployee has overtimeHours and monthlyBonus
• PartTimeEmployee has workingHours and hourlyRate
• ContractEmployee has contractDuration (in months) and projectName
Each class should implement ShowInfo() and SalaryDetails().
A CheckPromotionEligibility() method:
• FullTime: if overtimeHours > 20
• PartTime: if workingHours > 100
• Contract: if contractDuration > 12*/
