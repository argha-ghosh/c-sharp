using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    internal class Employee : Person
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value >= 0.0)
                    this.salary = value;
                else
                    this.salary = -2;
            }
        }

        internal override string Id
        {
            set { base.Id = value + "-E"; }
        }

        internal Employee(string name, string bloodGroup, AddressFormat address, double salary) : base(name, bloodGroup, address)
        {
            this.Salary = salary;
        }

        internal override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Salary: {0}\n", this.Salary);
        }
    }
}
