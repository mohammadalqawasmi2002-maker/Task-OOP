using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeManagementSystem
{
    public abstract class Employee : IWorkable
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public abstract void CalculateSalary();

        public virtual void DisplayInfo()
        {
            Console.WriteLine("ID: " + id + ", Name: " + name);
        }

        public abstract void Work();
    }
}