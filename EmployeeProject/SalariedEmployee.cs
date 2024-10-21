using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class SalariedEmployee : EmployeeAbstract
    {
        public double MonthlySalary { get; set; } //ozellikler

        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public override void DisplayDetails()
        {
            throw new NotImplementedException();
        }
    }
}
