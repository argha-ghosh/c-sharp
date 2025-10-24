using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppMID
{
    class FullTimeEmployee : Employee
    {
        public int OvertimeHours { get; set; }
        public decimal MonthlyBonus { get; set; }
         
        public FullTimeEmployee(int employeeId, string name, string department, decimal baseSalary, int overtimeHours, decimal monthlyBonus)
            : base(employeeId, name, department, baseSalary)
        { 
            OvertimeHours = overtimeHours;
            MonthlyBonus = monthlyBonus;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Full-Time] ID:  {EmployeeId}, Name: {Name}, Department:  {Department}");
        }

        public override void SalaryDetails()
        {
            decimal totalSalary = BaseSalary + MonthlyBonus;
            Console.WriteLine($"Base Salary: {BaseSalary}, Bonus: {MonthlyBonus}, Total Salary: {totalSalary}");
        }

        public override bool CheckPromotionEligibility()
        {
            return OvertimeHours > 20;
        }
    }

}
