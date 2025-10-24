using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMID
{
    class Program
    {
        static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee(101, "Alice", "HR", 3000, 25, 500);
            PartTimeEmployee pte = new PartTimeEmployee(102, "Bob", "Finance", 0, 120, 20);
            ContractEmployee ce = new ContractEmployee(103, "Charlie", "IT", 4000, 15, "Migration");

            Employee[] employees = { fte, pte, ce };

            foreach (var emp in employees)
            {
                emp.ShowInfo();
                emp.SalaryDetails();
                Console.WriteLine("Eligible for Promotion: " + (emp.CheckPromotionEligibility() ? "Yes" : "No"));
                Console.WriteLine(new string('-', 50));
                //Console.WriteLine("______________");
            }
        }
    }
}

