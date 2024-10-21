using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal abstract class EmployeeAbstract
    {
        int id;                                 //ozellikler
        string name;
        string surname;
        int age;

        public abstract double CalculateSalary();

        public abstract void DisplayDetails();
    }
}
