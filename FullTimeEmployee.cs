using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeManagementSystem
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, double fixedSalary) : base(id, name)
        {
            Salary = fixedSalary;
        }

        public override void CalculateSalary()
        {
        }

        public override void Work()
        {
            Console.WriteLine(Name + " is working full-time.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("ID: " + Id + ", Name: " + Name);
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine("Salary: " + Salary + " JOD");
        }
    }
}
