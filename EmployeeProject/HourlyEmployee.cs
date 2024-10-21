using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeProject
{
    internal class HourlyEmployee : EmployeeAbstract
    {
        public double HourlyRate; //ozellikler
        public double HoursWorked;

        public override double CalculateSalary()
        {
            double MounthSalary = HourlyRate * HoursWorked;
            return MounthSalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{HoursWorked} {HourlyRate}");
        }
    }
}
