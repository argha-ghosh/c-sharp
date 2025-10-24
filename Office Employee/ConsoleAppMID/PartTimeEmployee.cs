using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppMID
{
    class PartTimeEmployee : Employee
    {
        public int WorkingHours { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(int employeeId, string name, string department, decimal baseSalary, int workingHours, decimal hourlyRate)
            : base(employeeId, name, department, baseSalary)
        {
            WorkingHours = workingHours;
            HourlyRate = hourlyRate;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Part-Time] ID: {EmployeeId}, Name: {Name}, Department: {Department}");
        }

        public override void SalaryDetails()
        {
            decimal totalEarnings = WorkingHours * HourlyRate;
            Console.WriteLine($"Hourly Rate: {HourlyRate}, Hours Worked: {WorkingHours}, Total Earnings: {totalEarnings}");
        }

        public override bool CheckPromotionEligibility()
        {
            return WorkingHours > 100;
        }
    }

}
