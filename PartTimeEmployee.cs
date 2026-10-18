using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked) : base(id, name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            CalculateSalary(); 
        }

        public override void CalculateSalary()
        {
            Salary = HourlyRate * HoursWorked;
        }

        public override void Work()
        {
            Console.WriteLine(Name + " is working part-time.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("ID: " + Id + ", Name: " + Name);
            Console.WriteLine("Employee Type: Part-Time");
            Console.WriteLine("Salary: " + Salary + " JOD");
        }
    }
}